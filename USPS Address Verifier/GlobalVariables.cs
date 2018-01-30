/*
    GlobalVariables.cs - Holds and manages the global stats values for every run.
    Author: Nidesh Chitrakar (nideshchitrakar)
    Date: 01/23/2018
*/

namespace USPS_Address_Verifier
{
    public static class GlobalVariables
    {
        /// <summary>
        /// Stores the default values for stats.
        /// </summary>
        static GlobalVariables()
        {
            TimeElapsed = "";
            TotalScanned = 0;
            TotalErrors = 0;
            TotalActionReq = 0;
        }

        public static string TimeElapsed { get; private set; }
        public static void SetTimeElapsed(string newTime) { TimeElapsed = newTime; }

        public static int TotalScanned { get; private set; }
        public static void SetTotalScanned(int newNum) { TotalScanned = newNum; }

        public static int TotalErrors { get; private set; }
        public static void SetTotalErrors(int newNum) { TotalErrors = newNum; }

        public static int TotalActionReq { get; private set; }
        public static void SetTotalActionReq(int newNum) { TotalActionReq = newNum; }

        /// <summary>
        /// Sets everything back to default.
        /// </summary>
        public static void SetAllDefault()
        {
            TimeElapsed = "";
            TotalScanned = 0;
            TotalErrors = 0;
            TotalActionReq = 0;
        }
    }
}
