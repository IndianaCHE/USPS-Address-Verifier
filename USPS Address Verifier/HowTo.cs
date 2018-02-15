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
    public partial class HowTo : Form
    {
        public HowTo()
        {
            InitializeComponent();
            instructionHeader.Text = "To use the tool correctly please adhere to the following instructions:";
            step1.Text = "1. Make sure to have a valid USPS Web Tools API User ID with you.";
            step2.Text = "2. Click on the Browse button next to the Input File text box.";
            step3.Text = "3. By default, the output directory is the same as your input file directory. Click the Browse button next to the Output Directory text box to change it.";
            step4.Text = "4. After selecting the file, make sure that the tool has selected the correct headers. Else just make the changes accordingly.";
            step5.Text = "5. Press the Run Scan button to start the verifying process.";
        }

        private void gotItButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
