using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace USPS_Address_Verifier
{
    public partial class ValidatorUI : Form
    {
        private Tuple<string, int> stAddr;
        private Tuple<string, int> aptNo;
        private Tuple<string, int> city;
        private Tuple<string, int> state;
        private Tuple<string, int> zip;

        private int numberOfRecords = 0;

        public ValidatorUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for Input File Browse button click.
        /// </summary>
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // reset combobox texts to default
                stAddrBox.Text = "Address";
                aptBox.Text = "Address";
                cityBox.Text = "City";
                stateBox.Text = "State";
                zipBox.Text = "Zip";

                try
                {
                    filepath_box.Text = openFileDialog.FileName;

                    using (CsvReader csv = new CsvReader(new StreamReader(filepath_box.Text), true))
                    {
                        var headers = csv.GetFieldHeaders();

                        ComboBox[] boxes = new ComboBox[] { stAddrBox, aptBox, cityBox, stateBox, zipBox };

                        // reset the box selections and add new headers and None field for all combo boxes
                        foreach (var box in boxes)
                        {
                            box.Items.Clear();
                            box.SelectedIndex = -1;

                            box.Items.AddRange(headers);
                            box.Items.Insert(0, "None");
                        }

                        var last = headers.Last();

                        // handle auto selection of headers from list
                        foreach (var box in boxes)      // for each combo box
                        {
                            foreach (var header in headers)     // for each header in box
                            {
                                if (header.ToLower().Contains(box.Text.ToLower()))      // if text matches
                                {
                                    if ((box != aptBox) || (box == aptBox && stAddrBox.Text != header))
                                    {
                                        box.SelectedItem = header;      // select header if header not already selected
                                        break;
                                    }
                                }
                                if (header.Equals(last) && box.SelectedIndex == -1)     // if header is last item and still no match found
                                {
                                    box.SelectedItem = "None";      // set header to None
                                }
                            }
                        }
                    }

                    // enable the controls
                    stAddrBox.Enabled = true;
                    aptBox.Enabled = true;
                    cityBox.Enabled = true;
                    stateBox.Enabled = true;
                    zipBox.Enabled = true;
                    validateButton.Enabled = true;

                    numberOfRecords = File.ReadLines(filepath_box.Text).Count() - 1;
                    progressLabel.Text = "Items to scan: " + numberOfRecords.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Event handler for Output Directory Browse Button click.
        /// </summary>
        private void browseButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the directory to save the output files in.";
            folderBrowserDialog.ShowNewFolderButton = true;

            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                outpath_box.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Event handler for Run Scan button click.
        /// </summary>
        private void validateButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default["USPS_ID"].ToString() != "")
            {
                stAddr = new Tuple<string, int>(stAddrBox.SelectedItem.ToString(), stAddrBox.SelectedIndex - 1);
                aptNo = new Tuple<string, int>(aptBox.SelectedItem.ToString(), aptBox.SelectedIndex - 1);
                city = new Tuple<string, int>(cityBox.SelectedItem.ToString(), cityBox.SelectedIndex - 1);
                state = new Tuple<string, int>(stateBox.SelectedItem.ToString(), stateBox.SelectedIndex - 1);
                zip = new Tuple<string, int>(zipBox.SelectedItem.ToString(), zipBox.SelectedIndex - 1);

                var headers = new Dictionary<string, Tuple<string, int>>();
                headers.Add("Street Address", stAddr);
                headers.Add("Apt Number", aptNo);
                headers.Add("City", city);
                headers.Add("State", state);
                headers.Add("ZipCode", zip);

                if (outpath_box.Text == "")
                {
                    var outpath = Path.GetDirectoryName(filepath_box.Text) + "\\Results";
                    System.IO.Directory.CreateDirectory(outpath);
                    outpath_box.Text = outpath;
                }

                toggleInteractivity(false);

                backgroundWorker1.RunWorkerAsync(headers);
            }
            else
            {
                MessageBox.Show("Error: Please input a USPS ID to acess the API.");
            }
        }

        /// <summary>
        /// Cancels the async task.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            var message = "The program is still running. \nAre you sure you want to cancel?";
            var caption = "Warning";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                backgroundWorker1.CancelAsync();

                toggleInteractivity(true);
            }
        }

        /// <summary>
        /// Background worker to carry out the async task of validating a csv file.
        /// </summary>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            string USPSWebtoolUserID = Properties.Settings.Default["USPS_ID"].ToString();

            ValidateCsv validateCsv = new ValidateCsv(USPSWebtoolUserID, filepath_box.Text, outpath_box.Text);

            validateCsv.Validate((Dictionary<string,Tuple<string,int>>)e.Argument, numberOfRecords, worker, e);
        }

        /// <summary>
        /// Event handler on completion of async task.
        /// </summary>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                progressLabel.Text = "Cancelled";
                progressBar.Value = 0;

                ScanResults results = new ScanResults();
                results.Show();
            }
            else
            {
                progressLabel.Text = "Finished running the script";
                progressBar.Value = 0;

                ScanResults results = new ScanResults();
                results.Show();
            }

            toggleInteractivity(true);
        }

        private void toggleInteractivity(bool enable)
        {
            var toggle = true;
            if (!enable) toggle = false;

            stAddrBox.Enabled = toggle;
            aptBox.Enabled = toggle;
            cityBox.Enabled = toggle;
            stateBox.Enabled = toggle;
            zipBox.Enabled = toggle;

            validateButton.Enabled = toggle;
            cancelButton.Enabled = !toggle;

            filepath_box.Enabled = toggle;
            browseButton.Enabled = toggle;
            outpath_box.Enabled = toggle;
            browseButton2.Enabled = toggle;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressLabel.Text = progressBar.Value.ToString() + "% Complete";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                if (CloseCancel() == false)
                {
                    backgroundWorker1.CancelAsync();
                    e.Cancel = true;
                }
            }
        }

        public static bool CloseCancel()
        {
            const string message = "Are you sure you would like to close the application?";
            const string caption = "Close Application";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USPS_ID idMenu = new USPS_ID();
            idMenu.Show();
        }
        
        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }
    }
}
