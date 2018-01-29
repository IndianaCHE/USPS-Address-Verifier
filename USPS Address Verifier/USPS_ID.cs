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
    public partial class USPS_ID : Form
    {
        public USPS_ID()
        {
            InitializeComponent();
            uspsIdBox.Text = Properties.Settings.Default["USPS_ID"].ToString();
        }

        private void uspsIdDescription3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uspsIdDescription3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.usps.com/business/web-tools-apis/welcome.htm");
        }

        private void idEditButton_Click(object sender, EventArgs e)
        {
            uspsIdBox.Enabled = true;
            idSaveButton.Enabled = true;
        }

        private void idSaveButton_Click(object sender, EventArgs e)
        {
            uspsIdBox.Enabled = false;
            Properties.Settings.Default["USPS_ID"] = uspsIdBox.Text;
            Properties.Settings.Default.Save();
            idSaveButton.Enabled = false;
        }

        private void idDoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
