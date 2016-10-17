namespace KRSS
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.tbRSS5 = new System.Windows.Forms.TextBox();
            this.tbRSS4 = new System.Windows.Forms.TextBox();
            this.tbRSS3 = new System.Windows.Forms.TextBox();
            this.tbRSS2 = new System.Windows.Forms.TextBox();
            this.tbRSS1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.tbRSS5);
            this.gbSettings.Controls.Add(this.tbRSS4);
            this.gbSettings.Controls.Add(this.tbRSS3);
            this.gbSettings.Controls.Add(this.tbRSS2);
            this.gbSettings.Controls.Add(this.tbRSS1);
            this.gbSettings.Location = new System.Drawing.Point(16, 15);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSettings.Size = new System.Drawing.Size(343, 196);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Enter RSS URLs";
            // 
            // tbRSS5
            // 
            this.tbRSS5.Location = new System.Drawing.Point(9, 158);
            this.tbRSS5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRSS5.Name = "tbRSS5";
            this.tbRSS5.Size = new System.Drawing.Size(324, 22);
            this.tbRSS5.TabIndex = 4;
            this.tbRSS5.Text = "5";
            // 
            // tbRSS4
            // 
            this.tbRSS4.Location = new System.Drawing.Point(9, 124);
            this.tbRSS4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRSS4.Name = "tbRSS4";
            this.tbRSS4.Size = new System.Drawing.Size(324, 22);
            this.tbRSS4.TabIndex = 3;
            this.tbRSS4.Text = "4";
            // 
            // tbRSS3
            // 
            this.tbRSS3.Location = new System.Drawing.Point(9, 91);
            this.tbRSS3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRSS3.Name = "tbRSS3";
            this.tbRSS3.Size = new System.Drawing.Size(324, 22);
            this.tbRSS3.TabIndex = 2;
            this.tbRSS3.Text = "3";
            // 
            // tbRSS2
            // 
            this.tbRSS2.Location = new System.Drawing.Point(9, 58);
            this.tbRSS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRSS2.Name = "tbRSS2";
            this.tbRSS2.Size = new System.Drawing.Size(324, 22);
            this.tbRSS2.TabIndex = 1;
            this.tbRSS2.Text = "2";
            // 
            // tbRSS1
            // 
            this.tbRSS1.Location = new System.Drawing.Point(9, 25);
            this.tbRSS1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRSS1.Name = "tbRSS1";
            this.tbRSS1.Size = new System.Drawing.Size(324, 22);
            this.tbRSS1.TabIndex = 0;
            this.tbRSS1.Text = "1";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(89, 218);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 218);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 252);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "KRSS - Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TextBox tbRSS5;
        private System.Windows.Forms.TextBox tbRSS4;
        private System.Windows.Forms.TextBox tbRSS3;
        private System.Windows.Forms.TextBox tbRSS2;
        private System.Windows.Forms.TextBox tbRSS1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}