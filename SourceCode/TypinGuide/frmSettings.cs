using System;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;  
using System.IO;
using System.Speech.Synthesis;
using System.Collections.ObjectModel;



namespace prjTypinGuide
{
    public partial class frmSettings : Form
    {
        SpeechSynthesizer mySynth = new SpeechSynthesizer();
        public frmSettings()
        {
            InitializeComponent();
            GetInstalledVoices();
            this.Text = GlobalVarManager.TitleMessage;
            LoadBasicSettings();

            

            //GetInstalledVoices(mySynth);
            //string BasicSettingPath = Application.StartupPath + "\\tt\\BasicSettings\\BaseProperties.xml";
            //BasicSettings settings = new BasicSettings();

            //System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(BasicSettings));
            //System.IO.StreamReader file = new System.IO.StreamReader(@BasicSettingPath);
            ////System.IO.StreamReader file = new System.IO.StreamReader(@"c:\temp\SerializationOverview.xml");  
            //BasicSettings overview = (BasicSettings)reader.Deserialize(file);
            //volumeTrackBar.Value = overview.SynVolume;
            //speedTrackBar.Value = overview.SynRate;

            ////rdoStopCursorOnError.Checked = overview.StopCursorOnError;
            //rdoForgiveErrors.Checked = overview.ForgiveError;
            //chkEnableSound.Checked =overview.EnableSound;
            //chkCapitalLetter.Checked = overview.EnabelCapitalLetter;
            //chkEnableTextToSpeech.Checked = overview.EnableTextToSpeech;

            //mySynth.Rate=overview.SynRate;
           // mySynth.Volume = overview.SynVolume;
            //mySynth.SelectVoice = overview.SpeechVoice;

            //file.Close();
        }

        private void LoadBasicSettings()
        {
            rdoStopCursorOnError.Checked = GlobalVarManager.StopCursorOnError;
            rdoForgiveErrors.Checked = GlobalVarManager.ForgiveErrors;
            chkEnableSound.Checked = GlobalVarManager.EnableSound;
            chkCapitalLetter.Checked = GlobalVarManager.EnableCapitalLetter;
            chkEnableTextToSpeech.Checked = GlobalVarManager.EnableTextToSpeech;
           
            if (GlobalVarManager.EnableTextToSpeech)
            {
                cmbVoice.SelectedItem = GlobalVarManager.VoiceName;
                volumeTrackBar.Value = Convert.ToInt32(GlobalVarManager.SynVolume);
                speedTrackBar.Value = Convert.ToInt32(GlobalVarManager.SynRate);
            }
            else
            {

            }
        }

        private void GetInstalledVoices()
        {
            ReadOnlyCollection<InstalledVoice> voices = mySynth.GetInstalledVoices();

            if (voices.Count == 0)
            {
            }
            else
            {
                try
                {
                    VoiceInfo voiceInformation;

                    foreach (InstalledVoice v in voices)
                    {
                        voiceInformation = v.VoiceInfo;
                        cmbVoice.Items.Add(voiceInformation.Name.ToString());
                    }
                    cmbVoice.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
           //frmMain.StopCursorOnError = rdoStopCursorOnError.Checked;
           //frmMain.ForgiveErrors = rdoForgiveErrors.Checked;
           //frmMain.EnableSound = chkEnableSound.Checked;
           //frmMain.EnableCapitalLetter = chkCapitalLetter.Checked;

           //BasicSettings settings = new BasicSettings();
           //settings.StopCursorOnError = rdoStopCursorOnError.Checked;
           //settings.ForgiveError = rdoForgiveErrors.Checked;
           //settings.EnableSound = chkEnableSound.Checked;
           //settings.EnabelCapitalLetter = chkCapitalLetter.Checked;

           //XmlSerializer xs = new XmlSerializer(typeof(BasicSettings));  
  
           ////TextWriter txtWriter = new StreamWriter(@"F:\Serialization.xml");
           //string BasicSettingPath = Application.StartupPath + "\\tt\\BasicSettings\\BaseProperties.xml";
           //TextWriter txtWriter = new StreamWriter(@""+BasicSettingPath+"");

           //xs.Serialize(txtWriter, settings);    
           //txtWriter.Close();  
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string BasicSettingPatht = Application.StartupPath + "\\tt\\BasicSettings\\BaseProperties.xml";

                    XmlDocument doc = new XmlDocument();
                    doc.Load(BasicSettingPatht);

                    XmlElement element = doc.DocumentElement;

                    XmlNode nodeElement = element.SelectSingleNode("Basic[@ID='1']");
                    if (nodeElement != null)
                    {
                        //nodeElement.ChildNodes[0].InnerText = "";
                        //nodeElement.ChildNodes[1].InnerText = "";
                        GlobalVarManager.StopCursorOnError = rdoStopCursorOnError.Checked;

                        //nodeElement.ChildNodes[2].InnerText = "";
                        GlobalVarManager.ForgiveErrors = rdoForgiveErrors.Checked;

                        nodeElement.ChildNodes[3].InnerText = chkEnableSound.Checked.ToString();
                        GlobalVarManager.EnableSound = chkEnableSound.Checked;

                        //nodeElement.ChildNodes[4].InnerText = "";
                        GlobalVarManager.EnableCapitalLetter = chkCapitalLetter.Checked;

                        nodeElement.ChildNodes[5].InnerText = chkEnableTextToSpeech.Checked.ToString();
                        GlobalVarManager.EnableTextToSpeech = chkEnableTextToSpeech.Checked;

                        nodeElement.ChildNodes[6].InnerText = cmbVoice.Text;
                        GlobalVarManager.VoiceName = cmbVoice.Text;

                        nodeElement.ChildNodes[7].InnerText = mySynth.Rate.ToString();
                        GlobalVarManager.SynRate = mySynth.Rate.ToString();

                        nodeElement.ChildNodes[8].InnerText = mySynth.Volume.ToString();
                        GlobalVarManager.SynVolume = mySynth.Volume.ToString();

                        doc.Save(BasicSettingPatht);
                    }  



                    ////Application.Exit();
                    ////Environment.Exit(0);
                    //GlobalVarManager.StopCursorOnError = rdoStopCursorOnError.Checked;
                    //GlobalVarManager.ForgiveErrors = rdoForgiveErrors.Checked;
                    //GlobalVarManager.EnableSound = chkEnableSound.Checked;
                    //GlobalVarManager.EnableCapitalLetter = chkCapitalLetter.Checked;
                    //GlobalVarManager.EnableTextToSpeech = chkEnableTextToSpeech.Checked;

                    //BasicSettings settings = new BasicSettings();
                    //settings.StopCursorOnError = rdoStopCursorOnError.Checked;
                    //settings.ForgiveError = rdoForgiveErrors.Checked;
                    //settings.EnableSound = chkEnableSound.Checked;
                    //settings.EnabelCapitalLetter = chkCapitalLetter.Checked;
                    //settings.EnableTextToSpeech = chkEnableTextToSpeech.Checked;
                    //settings.SynRate= mySynth.Rate;
                    //settings.SynVolume = mySynth.Volume;
                    //settings.SpeechVoice = cmbVoice.Text;

                    //XmlSerializer xs = new XmlSerializer(typeof(BasicSettings));

                    ////TextWriter txtWriter = new StreamWriter(@"F:\Serialization.xml");
                    //string BasicSettingPath = Application.StartupPath + "\\tt\\BasicSettings\\BaseProperties.xml";
                    //TextWriter txtWriter = new StreamWriter(@"" + BasicSettingPath + "");

                    //xs.Serialize(txtWriter, settings);
                    //txtWriter.Close();
                }
                else
                {
                }
            }
            catch(Exception ex)
            {
            
            }
            finally { }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //string message = "Do you want to close this window?";
            string title = "Exit";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show(message, title, buttons);
            //if (result == DialogResult.Yes)
            //{
                this.Close();
            //}
            //else
            //{
            //    // Do something  
            //}  
        }

        private void volumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            mySynth.Volume = volumeTrackBar.Value;
        }

        private void speedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            mySynth.Rate = speedTrackBar.Value;
        }

        //private void chkEnableTextToSpeech_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (GlobalVarManager.EnableTextToSpeech == false)
        //    {
        //        GetInstalledVoices();
        //    }
        //}
    }

    //public class BasicSettings
    //{
    //    public bool StopCursorOnError { get; set; }
    //    public bool ForgiveError { get; set; }
    //    public bool EnableSound { get; set; }
    //    public bool EnabelCapitalLetter { get; set; }
    //    public bool EnableTextToSpeech { get; set; }
    //    public int SynRate { get; set; }
    //    public int SynVolume { get; set; }
    //    public string SpeechVoice { get; set; }
    //}
}
