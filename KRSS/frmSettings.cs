using System;
using System.Windows.Forms;

namespace KRSS
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["RSS1"] = tbRSS1.Text;
            Properties.Settings.Default["RSS2"] = tbRSS2.Text;
            Properties.Settings.Default["RSS3"] = tbRSS3.Text;
            Properties.Settings.Default["RSS4"] = tbRSS4.Text;
            Properties.Settings.Default["RSS5"] = tbRSS5.Text;
            frmMain.strRSSFeed[0] = tbRSS1.Text;
            frmMain.strRSSFeed[1] = tbRSS2.Text;
            frmMain.strRSSFeed[2] = tbRSS3.Text;
            frmMain.strRSSFeed[3] = tbRSS4.Text;
            frmMain.strRSSFeed[4] = tbRSS5.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            tbRSS1.Text = frmMain.strRSSFeed[0];
            tbRSS2.Text = frmMain.strRSSFeed[1];
            tbRSS3.Text = frmMain.strRSSFeed[2];
            tbRSS4.Text = frmMain.strRSSFeed[3];
            tbRSS5.Text = frmMain.strRSSFeed[4];
        }
    }
}
