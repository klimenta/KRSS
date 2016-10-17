////////////////////////////////////////////////////
//Kliment Andreev - 2016
//Program to show updates from 5 different RSS Feeds
//Simplified BSD license
////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Diagnostics;
using System.Linq;

namespace KRSS
{
    public partial class frmMain : Form
    {
        //Number of RSS feeds that we will monitor
        public const int cRSSElements = 5;
        //Windows for for the settings
        public static frmSettings frmBox;
        //XmlReader object
        private static XmlReader[] xrReader = new XmlReader[cRSSElements];
        //SyndicationFeed object
        private static SyndicationFeed[] sfFeed = new SyndicationFeed[cRSSElements];
        //5 ComboBoxes for the RSS feeds. This is where we will put the text of each feed.
        private static ComboBox[] cbRSSFeed = new ComboBox[cRSSElements];
        //These are all RSS URLs. Some RSS feeds have 5, 10, 30, etc entries
        public static List<string>[] lstrURLs = new List<string>[cRSSElements];
        //These are the old RSS URLs before each RSS update which occurs every minute
        public static List<string>[] lstrOldURLs = new List<string>[cRSSElements];
        //These are the RSS Feeds URLs. We need 5
        public static string[] strRSSFeed = new string[cRSSElements];

        //This method shows the baloon with a new RSS feed
        private void ShowUpdate(string strTitle, string strBody)
        {            
            niNotifyIconApp.Visible = true;
            if (strTitle != null)
            {
                niNotifyIconApp.BalloonTipTitle = strTitle;
            }
            if (strBody != null)
            {
                niNotifyIconApp.BalloonTipText = strBody;
            }            
            niNotifyIconApp.ShowBalloonTip(10000);
        }

        //This mething writes all errors in the Application Event Viewer with EventID 101
        public static void WriteApplicationEventLog(string strMessage)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry(strMessage, EventLogEntryType.Information, 101, 1);
            }
        }

        public frmMain()
        {
            InitializeComponent();
            //Initialize the variables and components
            //Comboboxes are created dynamically
            for (int i = 0; i < cRSSElements; i++)
            {
                lstrURLs[i] = new List<string>();
                lstrOldURLs[i] = new List<string>();
                cbRSSFeed[i] = new ComboBox();
                cbRSSFeed[i].Name = "cbRSSFeed" + i.ToString();
                cbRSSFeed[i].Top = 10 + i * 28;
                cbRSSFeed[i].Left = 12;
                cbRSSFeed[i].Width = 460;
                cbRSSFeed[i].Visible = true;
                cbRSSFeed[i].DropDownStyle = ComboBoxStyle.DropDownList;
                cbRSSFeed[i].SelectionChangeCommitted += new EventHandler(OpenURL);
                this.Controls.Add(cbRSSFeed[i]);
            }
        }

        //This method opens up the URL from the combobox
        //The default browser is used and it supports tabbed browsing
        public static void OpenURL(object sender, EventArgs e)
        {
            string strURL;
            string strcbName = ((sender as ComboBox).Name);
            //Get the selected story from the combobox
            int iSelected = ((sender as ComboBox).SelectedIndex);
            //Get the last character from the combobox name
            char clast = strcbName[strcbName.Length - 1];
            //Convert it to int  so we know which comboxbox was clicked
            int i = clast - '0';
            try
            {
                strURL = lstrURLs[i][iSelected].ToString();
            }
            catch (Exception ex)
            {
                //If something is wrong with the URL, show it on the screen
                MessageBox.Show(ex.ToString());
                //And write it to the application log
                WriteApplicationEventLog(ex.ToString());
                return;
            }
            //Opens up the default browser
            System.Diagnostics.Process.Start(strURL);
        }

        //This is the main method
        //It goes thru all 5 RSS Feeds and 
        //updates the comboboxes and the variables with any updates
        public static void UpdateRSSFeed()
        {
            for (int i = 0; i < cRSSElements; i++)
            {
                xrReader[i] = null;
                sfFeed[i] = null;
                cbRSSFeed[i].Items.Clear();
                lstrURLs[i].Clear();
                //If the RSS URL Feed is empty, skip it, don't report as error 404
                if (strRSSFeed[i] == "") break;
                try
                {
                    xrReader[i] = XmlReader.Create(strRSSFeed[i]);
                }
                catch (Exception ex)
                {
                    WriteApplicationEventLog(ex.ToString());
                }
                try
                {
                    sfFeed[i] = SyndicationFeed.Load(xrReader[i]);
                }
                catch (Exception ex)
                {
                    WriteApplicationEventLog(ex.ToString());
                }
                try
                {
                    xrReader[i].Close();
                }
                catch (Exception ex)
                {
                    WriteApplicationEventLog(ex.ToString());
                }
                try
                {
                    foreach (SyndicationItem item in sfFeed[i].Items)
                    {
                        //This is the short description of the RSS item
                        //e.g each description of the news article is in this variable
                        string strTitle = item.Title.Text;
                        //This is the URL of that article
                        string strURL = item.Links[0].Uri.ToString();
                        //The description goes to the combobox
                        cbRSSFeed[i].Items.Add(strTitle);
                        cbRSSFeed[i].SelectedIndex = 0;
                        //And the URL goes to this variable
                        lstrURLs[i].Add(strURL);
                    }
                }
                catch (Exception ex)
                {
                    cbRSSFeed[i].Items.Add("Error retrieving RSS Feed");
                    cbRSSFeed[i].SelectedIndex = 0;
                    WriteApplicationEventLog(ex.ToString());
                }
            }
        }

        //This method shows the settings form
        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmBox = new frmSettings();
            frmBox.ShowDialog();
        }

        //When the program starts
        //Get the 5 RSS Feed URLs and place them in strRSSFeed
        //Get the RSS feeds and make lstrOldURLs as a copy of lstrURLs
        //We'll need this for comparison if any RSS feed changes
        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cRSSElements; i++)
            {
                strRSSFeed[i] = Properties.Settings.Default["RSS" + (i + 1).ToString()].ToString();
            }
            UpdateRSSFeed();
            //Copy the array, i.e make lstrOldURLs equal as lstrURLs
            for (int i = 0; i < cRSSElements; i++)
            {
                foreach(string str in lstrURLs[i])
                {
                    lstrOldURLs[i].Add(str);
                }            
            }
        }

        //Each minute, update the RSS feed
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            UpdateRSSFeed();
            //Check if there is any difference between
            //lstrOldURLs and lstrURLs
            //put the difference is a new list lstrNewURLs
            for (int i = 0; i < cRSSElements; i++)
            {                      
                IEnumerable<string> lstrNewURLs = lstrURLs[i].Except(lstrOldURLs[i]);
                //For each update
                foreach (string strURLChange in lstrNewURLs)
                {
                    int c = 0;
                    //Get the host name
                    Uri uriUri = new Uri(strURLChange);
                    string strHost = uriUri.Host;
                    //Show the host name plus the text from the combobox as
                    //a balloon tip
                    ShowUpdate(strHost, cbRSSFeed[i].Items[c].ToString());
                    c++;
                }
                //Once the update is shown, clear the old RSS Feeds, they are not needed
                lstrOldURLs[i].Clear();
                //Copy the array, i.e make lstrOldURLs equal as lstrURLs                               
                foreach (string str in lstrURLs[i])
                {
                    lstrOldURLs[i].Add(str);
                }                
            }
        }

        //This method is used to minimize the form in the tray
        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                niNotifyIconApp.Visible = true;
                niNotifyIconApp.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                niNotifyIconApp.Visible = false;
            }
        }

        //Once in tray, use double-click to bring the program back
        private void niNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }
    }
}