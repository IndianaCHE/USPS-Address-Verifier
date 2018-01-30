/*
    ValidateCsv.cs - Utilizes CsvReader and Validator classes to read through
                     a csv file and retrieve proper address fields and validate
                     them against the USPS database.
    Author: Nidesh Chitrakar (nideshchitrakar)
    Date: 01/18/2018
*/

using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace USPS_Address_Verifier
{
    public class ValidateCsv
    {
        private string file = "";               // file path for input file
        private string outPath = "";            // output files directory
        private string USPSWebtoolUserID = "";  // USPS tools user ID

        /// <summary>
        /// Creates a new instance of Csv Validator
        /// </summary>
        /// <param name="USPSWebtoolUserID">The UserID required by the USPS Web Tools</param>
        /// <param name="file">Input file path</param>
        /// <param name="outPath">Output path directory</param>
        public ValidateCsv(string USPSWebtoolUserID, string file, string outPath)
        {
            this.USPSWebtoolUserID = USPSWebtoolUserID;
            this.file = file;
            this.outPath = outPath;
        }

        /// <summary>
        /// Goes through the specified csv file, reads the address fields based on fileHeaders,
        /// and writes files for correct addresses, incorrect addresses, as well as ones that require
        /// attention.
        /// </summary>
        /// <param name="fileHeaders">A dictionary of with key Address field type, and value a Tuple of header string and position int</param>
        /// <param name="numberOfRecords">Total number of rows to be read</param>
        /// <param name="worker">Background worker instance, for async task</param>
        /// <param name="e">Event handler instance to manage async task</param>
        public void Validate(Dictionary<string,Tuple<string,int>> fileHeaders, int numberOfRecords, BackgroundWorker worker, DoWorkEventArgs e)
        {
            // stopwatch to record script run time
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Validator validator = new Validator(USPSWebtoolUserID);
            
            Address addr = new Address();

            // stats to keep track of
            int totalScanned = 0;
            int totalErrors = 0;
            int totalActionReq = 0;

            // replace the following with directory to write the error and correct addresses files in
            // files will be created if no files already exists
            var errorFile = outPath + "\\error-list.csv";
            var correctFile = outPath + "\\correct-list.csv";
            var actionFile = outPath + "\\action-list.csv";

            CsvWriter errorWriter = new CsvWriter(errorFile);
            CsvWriter correctWriter = new CsvWriter(correctFile);
            CsvWriter actionWriter = new CsvWriter(actionFile);

            // open a CSV file with headers to read from
            using (CsvReader csv = new CsvReader(new StreamReader(file), true))
            {
                int fieldCount = csv.FieldCount;

                // headers for correct-list file
                var correctHeaders = csv.GetFieldHeaders().ToList();

                // headers for error-list file
                var errorHeaders = csv.GetFieldHeaders().ToList();
                errorHeaders.Add("Error");

                // headers for action-list file
                var actionHeaders = csv.GetFieldHeaders().ToList();
                actionHeaders.Add("Action Required");

                // write the headers to ther respective files
                correctWriter.WriteHeader(correctHeaders);
                errorWriter.WriteHeader(errorHeaders);
                actionWriter.WriteHeader(actionHeaders);

                while (csv.ReadNextRecord()) // while there is data to read
                {
                    if (worker.CancellationPending) // for canceling the scan; activated on press of Cancel button
                    {
                        e.Cancel = true;            // set the Cancel property of event handler to true and break out of loop
                        break;
                    }
                    else
                    {
                        totalScanned += 1;

                        // set address values for the address instance
                        addr.Address1 = (fileHeaders["Apt Number"].Item2 != -1) ? csv[fileHeaders["Apt Number"].Item2] : "";
                        addr.Address2 = (fileHeaders["Street Address"].Item2 != -1) ? csv[fileHeaders["Street Address"].Item2] : "";
                        addr.City = (fileHeaders["City"].Item2 != -1) ? csv[fileHeaders["City"].Item2] : "";
                        addr.State = (fileHeaders["State"].Item2 != -1) ? csv[fileHeaders["State"].Item2] : "";
                        addr.Zip = (fileHeaders["ZipCode"].Item2 != -1) ? csv[fileHeaders["ZipCode"].Item2] : "";

                        // validate the address and obtain dictionary containing information about the address
                        var result = validator.ValidateAddress(addr);

                        if (result.ContainsKey("Error") && !addr.modified)  // if error detected modify the address values
                        {
                            addr.ModifyAddress();
                            result = validator.ValidateAddress(addr);
                        }
                        if (result.ContainsKey("Error") && addr.modified)   // if modified address contains error mark it as incorrect
                        {
                            totalErrors += 1;

                            List<string> row = new List<string>();
                            for (int i = 0; i < correctHeaders.Count(); i++)
                            {
                                row.Add(csv[correctHeaders[i]]);
                            }
                            row.Add(result["Error"]);

                            errorWriter.AppendRow(row);
                        }
                        if (result.ContainsKey("Action Required"))      // if action required mark it as action required
                        {
                            totalActionReq += 1;

                            List<string> row = new List<string>();
                            for (int i = 0; i < correctHeaders.Count(); i++)
                            {
                                row.Add(csv[correctHeaders[i]]);
                            }
                            if (result.ContainsKey("Street Address")) row[fileHeaders["Street Address"].Item2] = result["Street Address"];
                            if (result.ContainsKey("Apt / Suite / Other")) row[fileHeaders["Apt Number"].Item2] = result["Apt / Suite / Other"];
                            if (result.ContainsKey("City")) row[fileHeaders["City"].Item2] = result["City"];
                            if (result.ContainsKey("State")) row[fileHeaders["State"].Item2] = result["State"];
                            if (result.ContainsKey("Zip5")) row[fileHeaders["ZipCode"].Item2] = result["Zip5"];
                            row.Add(result["Action Required"]);

                            actionWriter.AppendRow(row);
                        }
                        else if (!result.ContainsKey("Error"))      // else the address is correct
                        {
                            List<string> row = new List<string>();
                            for (int i = 0; i < correctHeaders.Count(); i++)
                            {
                                row.Add(csv[correctHeaders[i]]);
                            }
                            row[fileHeaders["Street Address"].Item2] = result["Street Address"];
                            if (result.ContainsKey("Apt / Suite / Other")) row[fileHeaders["Apt Number"].Item2] = result["Apt / Suite / Other"];
                            else row.Add(" ");
                            row[fileHeaders["City"].Item2] = result["City"];
                            row[fileHeaders["State"].Item2] = result["State"];
                            row[fileHeaders["ZipCode"].Item2] = result["Zip5"];

                            correctWriter.AppendRow(row);
                        }
                        addr.modified = false;      // set address modified value back to false

                        // update the progress of the script
                        int percentComplete = (int)((float)totalScanned / (float)numberOfRecords * 100);
                        worker.ReportProgress(percentComplete);
                    }
                }
            }

            stopWatch.Stop();
            // get the elapsed time as a TimeSpan value
            TimeSpan ts = stopWatch.Elapsed;

            // format and display the TimeSpan value
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            // set the global stats values accordingly
            GlobalVariables.SetTimeElapsed(elapsedTime);
            GlobalVariables.SetTotalScanned(totalScanned);
            GlobalVariables.SetTotalErrors(totalErrors);
            GlobalVariables.SetTotalActionReq(totalActionReq);
        }
    }
}
