namespace KRSS
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.ttToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.niNotifyIconApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(451, 151);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 23);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "*";
            this.ttToolTip.SetToolTip(this.btnSettings, "Settings");
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(356, 160);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "K.Andreev - 2016";
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 60000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // niNotifyIconApp
            // 
            this.niNotifyIconApp.BalloonTipText = "KRSS";
            this.niNotifyIconApp.Icon = ((System.Drawing.Icon)(resources.GetObject("niNotifyIconApp.Icon")));
            this.niNotifyIconApp.Text = "KRSS";
            this.niNotifyIconApp.Visible = true;
            this.niNotifyIconApp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niNotifyIcon_MouseDoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 176);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "KRSS v1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolTip ttToolTip;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.NotifyIcon niNotifyIconApp;
    }
}

