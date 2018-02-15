namespace USPS_Address_Verifier
{
    partial class ValidatorUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.browseButton = new System.Windows.Forms.Button();
            this.filepath_box = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outpath_box = new System.Windows.Forms.TextBox();
            this.browseButton2 = new System.Windows.Forms.Button();
            this.validateButton = new System.Windows.Forms.Button();
            this.stAddrBox = new System.Windows.Forms.ComboBox();
            this.aptBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.zipBox = new System.Windows.Forms.ComboBox();
            this.headersLabel = new System.Windows.Forms.Label();
            this.stAddrLabel = new System.Windows.Forms.Label();
            this.aptNumLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.progressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(395, 57);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // filepath_box
            // 
            this.filepath_box.Location = new System.Drawing.Point(12, 57);
            this.filepath_box.Name = "filepath_box";
            this.filepath_box.Size = new System.Drawing.Size(376, 22);
            this.filepath_box.TabIndex = 1;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(13, 37);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(65, 17);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input File";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(13, 89);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(112, 17);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Output Directory";
            // 
            // outpath_box
            // 
            this.outpath_box.Location = new System.Drawing.Point(12, 109);
            this.outpath_box.Name = "outpath_box";
            this.outpath_box.Size = new System.Drawing.Size(376, 22);
            this.outpath_box.TabIndex = 4;
            // 
            // browseButton2
            // 
            this.browseButton2.Location = new System.Drawing.Point(395, 109);
            this.browseButton2.Name = "browseButton2";
            this.browseButton2.Size = new System.Drawing.Size(75, 23);
            this.browseButton2.TabIndex = 5;
            this.browseButton2.Text = "Browse";
            this.browseButton2.UseVisualStyleBackColor = true;
            this.browseButton2.Click += new System.EventHandler(this.browseButton2_Click);
            // 
            // validateButton
            // 
            this.validateButton.Enabled = false;
            this.validateButton.Location = new System.Drawing.Point(267, 242);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(121, 23);
            this.validateButton.TabIndex = 6;
            this.validateButton.Text = "Run Scan";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // stAddrBox
            // 
            this.stAddrBox.Enabled = false;
            this.stAddrBox.FormattingEnabled = true;
            this.stAddrBox.Location = new System.Drawing.Point(12, 184);
            this.stAddrBox.Name = "stAddrBox";
            this.stAddrBox.Size = new System.Drawing.Size(121, 24);
            this.stAddrBox.TabIndex = 7;
            this.stAddrBox.Text = "Address";
            // 
            // aptBox
            // 
            this.aptBox.Enabled = false;
            this.aptBox.FormattingEnabled = true;
            this.aptBox.Location = new System.Drawing.Point(140, 184);
            this.aptBox.Name = "aptBox";
            this.aptBox.Size = new System.Drawing.Size(121, 24);
            this.aptBox.TabIndex = 8;
            this.aptBox.Text = "Address";
            // 
            // cityBox
            // 
            this.cityBox.Enabled = false;
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(267, 184);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 24);
            this.cityBox.TabIndex = 9;
            this.cityBox.Text = "City";
            // 
            // stateBox
            // 
            this.stateBox.Enabled = false;
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Location = new System.Drawing.Point(12, 241);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(121, 24);
            this.stateBox.TabIndex = 10;
            this.stateBox.Text = "State";
            // 
            // zipBox
            // 
            this.zipBox.Enabled = false;
            this.zipBox.FormattingEnabled = true;
            this.zipBox.Location = new System.Drawing.Point(139, 241);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(121, 24);
            this.zipBox.TabIndex = 11;
            this.zipBox.Text = "Zip";
            // 
            // headersLabel
            // 
            this.headersLabel.AutoSize = true;
            this.headersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headersLabel.Location = new System.Drawing.Point(13, 144);
            this.headersLabel.Name = "headersLabel";
            this.headersLabel.Size = new System.Drawing.Size(127, 17);
            this.headersLabel.TabIndex = 12;
            this.headersLabel.Text = "Specify Headers";
            // 
            // stAddrLabel
            // 
            this.stAddrLabel.AutoSize = true;
            this.stAddrLabel.Enabled = false;
            this.stAddrLabel.Location = new System.Drawing.Point(9, 164);
            this.stAddrLabel.Name = "stAddrLabel";
            this.stAddrLabel.Size = new System.Drawing.Size(102, 17);
            this.stAddrLabel.TabIndex = 13;
            this.stAddrLabel.Text = "Street Address";
            // 
            // aptNumLabel
            // 
            this.aptNumLabel.AutoSize = true;
            this.aptNumLabel.Enabled = false;
            this.aptNumLabel.Location = new System.Drawing.Point(137, 164);
            this.aptNumLabel.Name = "aptNumLabel";
            this.aptNumLabel.Size = new System.Drawing.Size(110, 17);
            this.aptNumLabel.TabIndex = 14;
            this.aptNumLabel.Text = "Apt/Box Number";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Enabled = false;
            this.cityLabel.Location = new System.Drawing.Point(264, 164);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 15;
            this.cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Enabled = false;
            this.stateLabel.Location = new System.Drawing.Point(9, 221);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(41, 17);
            this.stateLabel.TabIndex = 16;
            this.stateLabel.Text = "State";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Enabled = false;
            this.zipLabel.Location = new System.Drawing.Point(137, 221);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(65, 17);
            this.zipLabel.TabIndex = 17;
            this.zipLabel.Text = "Zip Code";
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(395, 242);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.progressLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(482, 25);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 19);
            // 
            // progressLabel
            // 
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IDToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // IDToolStripMenuItem
            // 
            this.IDToolStripMenuItem.Name = "IDToolStripMenuItem";
            this.IDToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.IDToolStripMenuItem.Text = "USPS ID";
            this.IDToolStripMenuItem.Click += new System.EventHandler(this.IDToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.howToToolStripMenuItem.Text = "How-To";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ValidatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.aptNumLabel);
            this.Controls.Add(this.stAddrLabel);
            this.Controls.Add(this.headersLabel);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.aptBox);
            this.Controls.Add(this.stAddrBox);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.browseButton2);
            this.Controls.Add(this.outpath_box);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.filepath_box);
            this.Controls.Add(this.browseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ValidatorUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USPS Address Verifier";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox filepath_box;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outpath_box;
        private System.Windows.Forms.Button browseButton2;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.ComboBox stAddrBox;
        private System.Windows.Forms.ComboBox aptBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.ComboBox zipBox;
        private System.Windows.Forms.Label headersLabel;
        private System.Windows.Forms.Label stAddrLabel;
        private System.Windows.Forms.Label aptNumLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel progressLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

