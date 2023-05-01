using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Speech.Synthesis;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace prjTypinGuide
{
    public partial class frmMain : Form
    {
        private clsLessonCoach _clsLessonCoach = new clsLessonCoach();
        public frmMain()
        {
            InitializeComponent();
            LoadBasicSettings();
            this.Text = GlobalVarManager.TitleMessage;
        }
        //public void LoadTitleMessage()
        //{
        //    //GlobalVarManager.TitleMessage = _clsLessonCoach.GetTitle(Application.StartupPath + "\\tt\\Title1.txt");
        //}

        public void LoadBasicSettings()
        {
            string BasicSettingPath = Application.StartupPath + "\\tt\\BasicSettings\\BaseProperties.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(BasicSettingPath);

            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes1 = root.GetElementsByTagName("Basic");

            foreach (XmlNode node in nodes1)
            {
                XmlNodeList childnodes = node.ChildNodes;
                foreach (XmlNode childnode in childnodes)
                {
                    switch (childnode.Name)
                    {
                        case "TitleMessage":
                            GlobalVarManager.TitleMessage=childnode.InnerText;
                            break;
                        case "StopCursorOnError":
                            if (!string.IsNullOrEmpty(childnode.InnerText))
                            GlobalVarManager.StopCursorOnError = Convert.ToBoolean(childnode.InnerText);
                            break;
                        case "ForgiveError":
                            if (!string.IsNullOrEmpty(childnode.InnerText))
                            GlobalVarManager.ForgiveErrors = Convert.ToBoolean(childnode.InnerText);
                            break;
                        case "EnableSound":
                            if (!string.IsNullOrEmpty(childnode.InnerText))
                            GlobalVarManager.EnableSound = Convert.ToBoolean(childnode.InnerText);
                            break;
                        case "EnabelCapitalLetter":
                            if (!string.IsNullOrEmpty(childnode.InnerText))
                            GlobalVarManager.EnableCapitalLetter = Convert.ToBoolean(childnode.InnerText);
                            break;
                        case "EnableTextToSpeech":
                            if (!string.IsNullOrEmpty(childnode.InnerText))
                            GlobalVarManager.EnableTextToSpeech = Convert.ToBoolean(childnode.InnerText);
                            break;
                        case "VoiceName":
                            {
                                GlobalVarManager.VoiceName = childnode.InnerText;
                                if (string.IsNullOrEmpty(GlobalVarManager.VoiceName))
                                {
                                    GlobalVarManager.EnableTextToSpeech = false;
                                }
                                else
                                {
                                    SpeechSynthesizer mySynth = new SpeechSynthesizer();
                                    bool isExist = GetInstalledVoices(mySynth, GlobalVarManager.VoiceName);
                                    if(isExist==false)
                                    {
                                        GlobalVarManager.EnableTextToSpeech = false;
                                    }
                                }
                                break;
                            }
                        case "SynRate":
                            GlobalVarManager.SynRate = childnode.InnerText;
                            break;
                        case "SynVolume":
                            GlobalVarManager.SynVolume = childnode.InnerText;
                            break;
                    }
                }
                childnodes = null;
                break;
            }
        }
        private bool GetInstalledVoices(SpeechSynthesizer synth, string voice)
        {
            Boolean isExist = false;
            ReadOnlyCollection<InstalledVoice> voices = synth.GetInstalledVoices();
            string voiceFound = string.Empty;
            if (voices.Count == 0)
            {
                return isExist;
            }
            else
            {
                try
                {
                    VoiceInfo voiceInformation;

                    foreach (InstalledVoice v in voices)
                    {
                        voiceInformation = v.VoiceInfo;
                        voiceFound = v.VoiceInfo.Name;
                        if (voiceFound == voice)
                        {
                            isExist = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return isExist;
        }

        private void btnSingleSentence_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTypinGuide st3 = new frmTypinGuide();
            st3.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {

            }
            finally
            { }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            { }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            using (frmAbout dialog = new frmAbout())
            {
                dialog.ShowDialog(this);
            }
        }

        private void btnSingleWord_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTypinWord st3 = new frmTypinWord();
            st3.ShowDialog();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings setting = new frmSettings();
            setting.ShowDialog();
        }

        private void btnOthers_MouseHover(object sender, EventArgs e)
        {
            btnOthers.BackColor= Color.FromArgb(108, 0, 217);
        }

        private void btnOthers_MouseLeave(object sender, EventArgs e)
        {
            btnOthers.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnSingleSentence_MouseHover(object sender, EventArgs e)
        {
            btnSingleSentence.BackColor = Color.FromArgb(116, 116, 116);
        }

        private void btnSingleSentence_MouseLeave(object sender, EventArgs e)
        {
            btnSingleSentence.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnSingleWord_MouseHover(object sender, EventArgs e)
        {
            btnSingleWord.BackColor = Color.FromArgb(116, 116, 116);
        }

        private void btnSingleWord_MouseLeave(object sender, EventArgs e)
        {
            btnSingleWord.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnSingleLetter_MouseHover(object sender, EventArgs e)
        {
            btnSingleLetter.BackColor = Color.FromArgb(116, 116, 116);
        }

        private void btnSingleLetter_MouseLeave(object sender, EventArgs e)
        {
            btnSingleLetter.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(108, 0, 217);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnHelp_MouseHover(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.FromArgb(108, 0, 217);
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.FromArgb(70, 70, 70);
        }
        public void SentenceIcon()
        {
            string directoryPath = Application.StartupPath + "\\Images\\SentenceIcon.png";
            btnSingleSentence.Image = Image.FromFile(directoryPath).GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnSingleSentence.ImageAlign = ContentAlignment.TopCenter;
            btnSingleSentence.TextAlign = ContentAlignment.BottomCenter;
            btnSingleSentence.FlatStyle = FlatStyle.Flat;
        }
        public void WordIcon()
        {
            string directoryPath = Application.StartupPath + "\\Images\\WordIcon.png";
            btnSingleWord.Image = Image.FromFile(directoryPath).GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnSingleWord.ImageAlign = ContentAlignment.TopCenter;
            btnSingleWord.TextAlign = ContentAlignment.BottomCenter;
            btnSingleWord.FlatStyle = FlatStyle.Flat;
        }
        public void LetterIcon()
        {
            string directoryPath = Application.StartupPath + "\\Images\\LetterIcon.png";
            btnSingleLetter.Image = Image.FromFile(directoryPath).GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnSingleLetter.ImageAlign = ContentAlignment.TopCenter;
            btnSingleLetter.TextAlign = ContentAlignment.BottomCenter;
            btnSingleLetter.FlatStyle = FlatStyle.Flat;
        }
        public void ExitIcon()
        {
            string directoryPath = Application.StartupPath + "\\Images\\Exit.png";
            btnExit.Image = Image.FromFile(directoryPath).GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnExit.ImageAlign = ContentAlignment.TopCenter;
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.FlatStyle = FlatStyle.Flat;
        }
        public void HelpIcon()
        {
            string directoryPath = Application.StartupPath + "\\Images\\Help.png";
            btnHelp.Image = Image.FromFile(directoryPath).GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnHelp.ImageAlign = ContentAlignment.TopCenter;
            btnHelp.TextAlign = ContentAlignment.BottomCenter;
            btnHelp.FlatStyle = FlatStyle.Flat;
        }
        public void LinkIcon()
        {
            string directoryPath = Application.StartupPath + "\\Images\\Link.png";
            btnOthers.Image = Image.FromFile(directoryPath).GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnOthers.ImageAlign = ContentAlignment.TopCenter;
            btnOthers.TextAlign = ContentAlignment.BottomCenter;
            btnOthers.FlatStyle = FlatStyle.Flat;
        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            btnSingleSentence.FlatStyle = FlatStyle.Flat;
            btnSingleSentence.FlatAppearance.BorderSize = 0;
            btnOthers.FlatStyle = FlatStyle.Flat;
            btnOthers.FlatAppearance.BorderSize = 0;
            btnSingleWord.FlatStyle = FlatStyle.Flat;
            btnSingleWord.FlatAppearance.BorderSize = 0;
            btnSingleLetter.FlatStyle = FlatStyle.Flat;
            btnSingleLetter.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            List<DirectoryFiles> dirFileList = new List<DirectoryFiles>();
            string directoryPath = Application.StartupPath + "\\Images\\keyboard.png";
            pictureBox1.Image = Image.FromFile(directoryPath);

            ExitIcon();
            HelpIcon();
            SentenceIcon();
            LetterIcon();
            WordIcon();
            LinkIcon();
        }

        private void btnSingleLetter_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTypinLetter st3 = new frmTypinLetter();
            st3.ShowDialog();
        }
    }

    public static class GlobalVarManager
    {
        private static string _titleMessage = string.Empty;
        public static string TitleMessage
        {
            get { return _titleMessage; }
            set { _titleMessage = value; }
        }

        private static bool _stopCursorOnError = true;
        public static bool StopCursorOnError
        {
            get { return _stopCursorOnError; }
            set { _stopCursorOnError = value; }
        }

        private static bool _forgiveErrors = false;
        public static bool ForgiveErrors
        {
            get { return _forgiveErrors; }
            set { _forgiveErrors = value; }
        }

        private static bool _enableCapitalLetter = false;
        public static bool EnableCapitalLetter
        {
            get { return _enableCapitalLetter; }
            set { _enableCapitalLetter = value; }
        }

        private static bool _enableSound = false;
        public static bool EnableSound
        {
            get { return _enableSound; }
            set { _enableSound = value; }
        }

        private static bool _enableTextToSpeech = false;
        public static bool EnableTextToSpeech
        {
            get { return _enableTextToSpeech; }
            set { _enableTextToSpeech = value; }
        }

        private static string _voiceName = string.Empty;
        public static string VoiceName
        {
            get { return _voiceName; }
            set { _voiceName = value; }
        }

        private static string _synRate = string.Empty;
        public static string SynRate
        {
            get { return _synRate; }
            set { _synRate = value; }
        }

        private static string _synVolume = string.Empty;
        public static string SynVolume
        {
            get { return _synVolume; }
            set { _synVolume = value; }
        }

        private static string _enabledPageName = string.Empty;
        public static string EnabledPageName
        {
            get { return _enabledPageName; }
            set { _enabledPageName = value; }
        }
    }
}
