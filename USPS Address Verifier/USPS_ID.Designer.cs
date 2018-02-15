namespace USPS_Address_Verifier
{
    partial class USPS_ID
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
            this.uspsIdBox = new System.Windows.Forms.TextBox();
            this.uspsIdLabel = new System.Windows.Forms.Label();
            this.uspsIdDescription1 = new System.Windows.Forms.Label();
            this.idEditButton = new System.Windows.Forms.Button();
            this.idSaveButton = new System.Windows.Forms.Button();
            this.idDoneButton = new System.Windows.Forms.Button();
            this.uspsIdDescription2 = new System.Windows.Forms.Label();
            this.uspsIdDescription3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // uspsIdBox
            // 
            this.uspsIdBox.Enabled = false;
            this.uspsIdBox.Location = new System.Drawing.Point(103, 64);
            this.uspsIdBox.Name = "uspsIdBox";
            this.uspsIdBox.Size = new System.Drawing.Size(167, 22);
            this.uspsIdBox.TabIndex = 0;
            // 
            // uspsIdLabel
            // 
            this.uspsIdLabel.AutoSize = true;
            this.uspsIdLabel.Location = new System.Drawing.Point(20, 67);
            this.uspsIdLabel.Name = "uspsIdLabel";
            this.uspsIdLabel.Size = new System.Drawing.Size(62, 17);
            this.uspsIdLabel.TabIndex = 1;
            this.uspsIdLabel.Text = "USPS ID";
            // 
            // uspsIdDescription1
            // 
            this.uspsIdDescription1.AutoSize = true;
            this.uspsIdDescription1.Location = new System.Drawing.Point(12, 9);
            this.uspsIdDescription1.Name = "uspsIdDescription1";
            this.uspsIdDescription1.Size = new System.Drawing.Size(249, 17);
            this.uspsIdDescription1.TabIndex = 2;
            this.uspsIdDescription1.Text = "Enter your USPS ID to access the API.";
            // 
            // idEditButton
            // 
            this.idEditButton.Location = new System.Drawing.Point(12, 103);
            this.idEditButton.Name = "idEditButton";
            this.idEditButton.Size = new System.Drawing.Size(75, 23);
            this.idEditButton.TabIndex = 3;
            this.idEditButton.Text = "Edit";
            this.idEditButton.UseVisualStyleBackColor = true;
            this.idEditButton.Click += new System.EventHandler(this.idEditButton_Click);
            // 
            // idSaveButton
            // 
            this.idSaveButton.Enabled = false;
            this.idSaveButton.Location = new System.Drawing.Point(103, 103);
            this.idSaveButton.Name = "idSaveButton";
            this.idSaveButton.Size = new System.Drawing.Size(75, 23);
            this.idSaveButton.TabIndex = 4;
            this.idSaveButton.Text = "Save";
            this.idSaveButton.UseVisualStyleBackColor = true;
            this.idSaveButton.Click += new System.EventHandler(this.idSaveButton_Click);
            // 
            // idDoneButton
            // 
            this.idDoneButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.idDoneButton.Location = new System.Drawing.Point(195, 103);
            this.idDoneButton.Name = "idDoneButton";
            this.idDoneButton.Size = new System.Drawing.Size(75, 23);
            this.idDoneButton.TabIndex = 5;
            this.idDoneButton.Text = "Done";
            this.idDoneButton.UseVisualStyleBackColor = true;
            this.idDoneButton.Click += new System.EventHandler(this.idDoneButton_Click);
            // 
            // uspsIdDescription2
            // 
            this.uspsIdDescription2.AutoSize = true;
            this.uspsIdDescription2.Location = new System.Drawing.Point(12, 28);
            this.uspsIdDescription2.Name = "uspsIdDescription2";
            this.uspsIdDescription2.Size = new System.Drawing.Size(123, 17);
            this.uspsIdDescription2.TabIndex = 6;
            this.uspsIdDescription2.Text = "Register for an ID ";
            // 
            // uspsIdDescription3
            // 
            this.uspsIdDescription3.AutoSize = true;
            this.uspsIdDescription3.Location = new System.Drawing.Point(129, 28);
            this.uspsIdDescription3.Name = "uspsIdDescription3";
            this.uspsIdDescription3.Size = new System.Drawing.Size(37, 17);
            this.uspsIdDescription3.TabIndex = 7;
            this.uspsIdDescription3.TabStop = true;
            this.uspsIdDescription3.Text = "here";
            this.uspsIdDescription3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uspsIdDescription3_LinkClicked);
            // 
            // USPS_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.ControlBox = false;
            this.Controls.Add(this.uspsIdDescription3);
            this.Controls.Add(this.uspsIdDescription2);
            this.Controls.Add(this.idDoneButton);
            this.Controls.Add(this.idSaveButton);
            this.Controls.Add(this.idEditButton);
            this.Controls.Add(this.uspsIdDescription1);
            this.Controls.Add(this.uspsIdLabel);
            this.Controls.Add(this.uspsIdBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "USPS_ID";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USPS ID Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uspsIdBox;
        private System.Windows.Forms.Label uspsIdLabel;
        private System.Windows.Forms.Label uspsIdDescription1;
        private System.Windows.Forms.Button idEditButton;
        private System.Windows.Forms.Button idSaveButton;
        private System.Windows.Forms.Button idDoneButton;
        private System.Windows.Forms.Label uspsIdDescription2;
        private System.Windows.Forms.LinkLabel uspsIdDescription3;
    }
}