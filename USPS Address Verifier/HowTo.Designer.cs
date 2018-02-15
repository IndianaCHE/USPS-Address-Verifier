namespace USPS_Address_Verifier
{
    partial class HowTo
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
            this.gotItButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.instructionHeader = new System.Windows.Forms.Label();
            this.step1 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.Label();
            this.step3 = new System.Windows.Forms.Label();
            this.step4 = new System.Windows.Forms.Label();
            this.step5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gotItButton
            // 
            this.gotItButton.Location = new System.Drawing.Point(295, 218);
            this.gotItButton.Name = "gotItButton";
            this.gotItButton.Size = new System.Drawing.Size(75, 23);
            this.gotItButton.TabIndex = 0;
            this.gotItButton.Text = "Got It!";
            this.gotItButton.UseVisualStyleBackColor = true;
            this.gotItButton.Click += new System.EventHandler(this.gotItButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.step1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.step2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.step3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.step4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.step5, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 47);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(358, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 116);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // instructionHeader
            // 
            this.instructionHeader.AutoSize = true;
            this.instructionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionHeader.Location = new System.Drawing.Point(9, 9);
            this.instructionHeader.MaximumSize = new System.Drawing.Size(358, 0);
            this.instructionHeader.Name = "instructionHeader";
            this.instructionHeader.Size = new System.Drawing.Size(137, 17);
            this.instructionHeader.TabIndex = 0;
            this.instructionHeader.Text = "instructionHeader";
            // 
            // step1
            // 
            this.step1.AutoSize = true;
            this.step1.Location = new System.Drawing.Point(3, 0);
            this.step1.MaximumSize = new System.Drawing.Size(345, 0);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(43, 17);
            this.step1.TabIndex = 1;
            this.step1.Text = "step1";
            // 
            // step2
            // 
            this.step2.AutoSize = true;
            this.step2.Location = new System.Drawing.Point(3, 17);
            this.step2.MaximumSize = new System.Drawing.Size(345, 0);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(43, 17);
            this.step2.TabIndex = 2;
            this.step2.Text = "step2";
            // 
            // step3
            // 
            this.step3.AutoSize = true;
            this.step3.Location = new System.Drawing.Point(3, 34);
            this.step3.MaximumSize = new System.Drawing.Size(345, 0);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(43, 17);
            this.step3.TabIndex = 3;
            this.step3.Text = "step3";
            // 
            // step4
            // 
            this.step4.AutoSize = true;
            this.step4.Location = new System.Drawing.Point(3, 51);
            this.step4.MaximumSize = new System.Drawing.Size(345, 0);
            this.step4.Name = "step4";
            this.step4.Size = new System.Drawing.Size(43, 17);
            this.step4.TabIndex = 4;
            this.step4.Text = "step4";
            // 
            // step5
            // 
            this.step5.AutoSize = true;
            this.step5.Location = new System.Drawing.Point(3, 68);
            this.step5.MaximumSize = new System.Drawing.Size(345, 0);
            this.step5.Name = "step5";
            this.step5.Size = new System.Drawing.Size(43, 17);
            this.step5.TabIndex = 5;
            this.step5.Text = "step5";
            // 
            // HowTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.instructionHeader);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gotItButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "HowTo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How To";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gotItButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label instructionHeader;
        private System.Windows.Forms.Label step1;
        private System.Windows.Forms.Label step2;
        private System.Windows.Forms.Label step3;
        private System.Windows.Forms.Label step4;
        private System.Windows.Forms.Label step5;
    }
}