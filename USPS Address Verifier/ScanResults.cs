using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USPS_Address_Verifier
{
    public partial class ScanResults : Form
    {
        public ScanResults()
        {
            InitializeComponent();
            label1.Text = "Total Run Time: " + GlobalVariables.TimeElapsed;
            label2.Text = "Total records scanned: " + GlobalVariables.TotalScanned;
            label3.Text = "Total errors detected: " + GlobalVariables.TotalErrors;
            label4.Text = "Total actions required: " + GlobalVariables.TotalActionReq;
            GlobalVariables.SetAllDefault();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
