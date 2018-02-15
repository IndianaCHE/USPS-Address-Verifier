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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            aboutLabel.Text = "USPS Address Verifier v1";
            descriptionLabel.Text = "Verify addresses in a CSV file. Made using USPS Web Tools API.";
            copyrightLabel.Text = "Copyright (c) 2018 Indiana Commission for Higher Education";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
