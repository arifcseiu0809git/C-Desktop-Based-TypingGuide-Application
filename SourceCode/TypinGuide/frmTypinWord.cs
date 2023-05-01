using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace prjTypinGuide
{
    public partial class frmTypinWord : Form
    {
        public frmTypinWord()
        {
            InitializeComponent();

            //Double key Buttons
            DoubleKeyButtons();
        }

        SpeechSynthesizer mySynth = new SpeechSynthesizer();
        private void DoubleKeyButtons()
        {
            btnColonSemiColon.Text = @":" + Environment.NewLine + @";";
            btnQuotation.Text = @"""" + Environment.NewLine + @"'";
            //btn7And.Text = @"&" + Environment.NewLine + @"7";
            btn7And.Text = @"&&" + Environment.NewLine + @"7";
        }

        #region Variables Members

        private int currentLessonFontSize = 14;
        private int currentPlusFont = 0;
        private int currentMinusFont = 0;
        private int currentWrongCount = 0;
        //public bool IsWrongKey = false;

        private bool IsLessonStarted = false;
        private string currentLessonPathName = string.Empty;
        private string _lbSelectedLessonForTyping = string.Empty;

        //public bool StopCursorOnError;
        //public bool ForgiveErrors;
        //public bool EnableCapitalLetter;
        //public bool EnableSound;
        //public bool EnableTextToSpeech;
        //public int SynRate;
        //public int SynVolume;
        //public string SpeechVoice;

        //public List<Label> LblUpperTitleMsgList = new List<Label>();
        public List<Label> LblFromCoachLessonList = new List<Label>();
        public List<Label> LblFromStudentGivenAnsList = new List<Label>();
        //public List<Label> LblCharacterScoreMsgList = new List<Label>();
        //public List<Label> LblWordScoreMsgList = new List<Label>();

        //public List<Label> LblCharPerMinList = new List<Label>();
        //public List<Label> LblWordPerMinList = new List<Label>();

        //public List<Label> lblFromCoach7 = new List<Label>();
        //public List<Label> lblFromStudent8 = new List<Label>();
        //public List<Label> lblMessage1 = new List<Label>();



        //create new instance of class clsDisplay
        private readonly clsDisplay _clsDisplay = new clsDisplay();



        //create new instance of class clsLessonCoach
        private clsLessonCoach _clsLessonCoach = new clsLessonCoach();

        private bool keystrokeProcessed;
        private bool KeyStillPressed;
        private bool p;

        //Variables For Stop Watch 
        private byte qHour;
        private byte qMinute;
        private byte qSecond;
        private byte LineTyped;
        private int t = 0;
        private int t2 = 0;

        #endregion


        #region Form Events

        private void frmTypinGuide_Activated(object sender, EventArgs e)
        {
            //Keyboard.offCapsLock();
        }

        public void frmTypinGuide_Load(object sender, EventArgs e)
        {
            LoadAllLessons();
            FormLoadDefaultData();
        }
        //public void LoadBasicSettings()
        //{
        //    string BasicSettingPath = Application.StartupPath + "\\tt\\BasicSettings\\BaseProperties.xml";
        //    BasicSettings settings = new BasicSettings();

        //    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(BasicSettings));
        //    System.IO.StreamReader file = new System.IO.StreamReader(@BasicSettingPath);
        //    BasicSettings overview = (BasicSettings)reader.Deserialize(file);

        //    StopCursorOnError = overview.StopCursorOnError;
        //    ForgiveErrors = overview.ForgiveError;
        //    EnableCapitalLetter = overview.EnabelCapitalLetter;
        //    EnableSound = overview.EnableSound;
        //    EnableTextToSpeech = overview.EnableTextToSpeech;
        //    SynRate = overview.SynRate;
        //    SynVolume = overview.SynVolume;
        //    SpeechVoice = overview.SpeechVoice;
        //    if (SpeechVoice == "Not found")
        //    {
        //        MessageBox.Show("Speech voice not found!");
        //        EnableTextToSpeech = false;
        //    }
        //    mySynth.Volume = SynVolume;
        //    mySynth.Rate = SynRate;

        //    file.Close();
        //}

        public void LoadBasicSettings()
        {
            mySynth.Volume = Convert.ToInt32(GlobalVarManager.SynVolume);
            mySynth.Rate = Convert.ToInt32(GlobalVarManager.SynRate);
        }
        private void FormLoadDefaultData()
        {
            LoadBasicSettings();
            _clsLessonCoach = new clsLessonCoach();
            lblTime.Text = "0 : 0 : 0";

            this.Text = GlobalVarManager.TitleMessage; //_clsLessonCoach.GetTitle(Application.StartupPath + "\\tt\\Title1.txt");

            _clsLessonCoach.textFileName7 = Application.StartupPath + "\\tt\\guideX1.txt";
            //pathname where the guideX1.txt file is kept
            _clsLessonCoach.GetGuideX(_clsLessonCoach.textFileName7);

            //method call to read the contents of guideX1.txt into memory

            //at startup all the four custom-made displays are created by making following function calls
            //_clsDisplay.ShowLblUpperTitleMsg(this);

            _clsDisplay.ShowLblFromCoachLesson(this);
            _clsDisplay.ShowLblFromStudentGivenAns(this);


            //_clsDisplay.ShowLblMessageEnd(this);
            //_clsDisplay.ShowLblWordMessge(this);

            //_clsDisplay.ShowLblCharacterPerMinMessge(this);
            //_clsDisplay.ShowLblWordPerMinMessge(this);

            //mdlAPI.Beep(400, 200);
            //_clsDisplay.clearDisplay(LblUpperTitleMsgList);
            lblUpperTitleMsg.Text = "";
            _clsDisplay.ClearDisplayText(LblFromCoachLessonList);
            //_clsDisplay.ClearDisplayText(LblFromStudentGivenAnsList);
            _clsLessonCoach.clearDisplayFromStudent(LblFromStudentGivenAnsList);

            lblCharacterScoreMsg.Text = "";
            lblWordScoreMsg.Text = "";
            lblCharPerMin.Text = "";
            lblWordPerMin.Text = "";

            //this is a function call to read contents ex.txt holding the typing lesson
            string currentApplicationPath = Application.StartupPath;

            if (!string.IsNullOrEmpty(_lbSelectedLessonForTyping))
            {
                currentLessonPathName = currentApplicationPath + "\\tt\\PracticeLessons\\Word\\" + _lbSelectedLessonForTyping;
            }
            else
            {
                currentLessonPathName = currentApplicationPath + "\\tt\\PracticeLessons\\Word\\Lesson 1.txt";
            }
            bool isCorrect = _clsLessonCoach.getNewLessonForWord(currentLessonPathName);
            if (isCorrect == false)
            {
                return;
            }
            //_clsLessonCoach.getNewLesson(Application.StartupPath + "\\tt\\ex.txt");
            typingProgressBar.Value = 0;
            typingProgressBar.Maximum = mdlAPI.lessonLeangth;
            DisplayProgressBarPercentage();


            //the contents read in the above line are now displayed on the custom-made display, FromCoach7
            _clsLessonCoach.displayNewLesson(LblFromCoachLessonList, currentLessonFontSize);
            _clsLessonCoach.KB_ActiveFlag = true;

            //this is the message that you see in the bottom display at the begining of a typing drill
            //_clsDisplay.displayTheMessage("click in the box below to begin typing...", lblCharacterScoreMsg);
            //_clsDisplay.DispalyWordWiseScore("click in the box below to begin typing...", lblWordScoreMsg);
            _clsDisplay.displayTheMessage("Character score will be here", lblCharacterScoreMsg);
            _clsDisplay.DispalyWordWiseScore("Word score will be here", lblWordScoreMsg);
            _clsDisplay.DispalyCharacterPerminScore("Character perminute will be here", lblCharPerMin);
            _clsDisplay.DispalyCharacterPerminScore("Word perminute will be here", lblWordPerMin);


            //load flashing texts
            mdlAPI.getFlashText();

            qSecond = 0;
            qMinute = 0;
            qHour = 0;
            timer1.Enabled = true;

            mdlAPI.getEndFlashText();
            _clsLessonCoach.x = 0;
            ClearTypedLetterHighlighted();
            textBox2.Text = string.Empty;
            textBox2.Focus();

        }

        //private void LessonDataLoad()
        //{
        //    _clsDisplay.ClearDisplayText(LblFromCoachLessonList);
        //    //LblFromStudentGivenAnsList.Clear() ;
        //    _clsLessonCoach.clearDisplayFromStudent(LblFromStudentGivenAnsList);

        //    string currentApplicationPath = Application.StartupPath;

        //    if (!string.IsNullOrEmpty(_dgvSelectedLessonForTyping))
        //    {
        //        currentLessonPathName = currentApplicationPath + "\\tt\\PracticeLessons\\" + _dgvSelectedLessonForTyping;
        //    }
        //    else
        //    {
        //        currentLessonPathName = currentApplicationPath + "\\tt\\ex.txt";
        //    }
        //    _clsLessonCoach.getNewLesson(currentLessonPathName);
        //    typingProgressBar.Maximum = mdlAPI.lessonLeangth;


        //    //the contents read in the above line are now displayed on the custom-made display, FromCoach7
        //    //LblFromCoachLessonList
        //    _clsLessonCoach.displayNewLesson(LblFromCoachLessonList , currentLessonFontSize);
        //    _clsLessonCoach.KB_ActiveFlag = true;
        //}

        private void frmTypinGuide_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        #endregion


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetBackEnterKey(e);


            //make timer off to stop flashing text
            timer1.Enabled = false;

            //this method is for the built-in KeyPress event
            //to help you understand it, please refer to the documentation pertaining to the 2nd argument (ie. KeyPressEventArgs  e)
            //if KB_ActiveFlag is false, the code here would be skipped
            if (_clsLessonCoach.KB_ActiveFlag == true)
            {
                //checks condition to allow KB input-Start
                if (!keystrokeProcessed)
                {
                    //KeyPress processing-START
                    //----------------------------------------------

                    //switch (e.KeyValue)
                    //{
                    //    case (int)Keys.A:
                    //        MessageBox.Show(@"A is pressed");
                    //        break;
                    //}


                    char c = Convert.ToChar(e.KeyChar);

                    if (GlobalVarManager.EnableTextToSpeech)
                    {
                        if (!String.IsNullOrEmpty(GlobalVarManager.VoiceName) && !String.IsNullOrEmpty(c.ToString()))
                        {
                            mySynth.SelectVoice(GlobalVarManager.VoiceName);
                            mySynth.SpeakAsync(c.ToString());

                            //CancelButton.Enabled = true;
                        }
                    }

                    if (c == 8 || c == 9 || c == 13) //ignore BackSpace n Tab key during a typing drill
                        return;

                    textBox2.Text = string.Empty;
                    // this is the scenario before the first keystroke
                    // this control structure is needed to implement the scheme for ignoring the case with multiple keys pressed
                    if (_clsLessonCoach.x < 1)
                    {

                        timer3.Enabled = true; // Starting Quick Watch


                        if (GlobalVarManager.EnableCapitalLetter)
                        {
                            mdlAPI.studentInputX[_clsLessonCoach.x] = Char.ToUpper(c);
                        }
                        else
                        {
                            mdlAPI.studentInputX[_clsLessonCoach.x] = c;
                        }
                        // this is the first character entered from keyboard. Its stored into studentInputX array as the first element
                        // this first character entered from keyboard is compared to the character that the student attempted to duplicate


                        //Only lower case
                        //if (mdlAPI.studentInputX[_clsLessonCoach.x].ToString().ToLower() ==
                        //    mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString()
                        //        .ToLower())
                        if (mdlAPI.studentInputX[_clsLessonCoach.x].ToString() ==
                            mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString())
                        {
                            //========================================

                            if (
                                mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString() ==
                                " ")
                            {
                                //if (_clsLessonCoach.CorrectCharacterCount != 1) //Because of A is letter also word
                                if (_clsLessonCoach.CorrectCharacterCount >= 1)
                                {
                                    if (currentWrongCount == 0)
                                    {
                                        _clsLessonCoach.CorrectWordCount += 1;
                                    }
                                    else
                                    {
                                        _clsLessonCoach.IncorrectWordCount += 1;
                                    }
                                }
                                currentWrongCount = 0;

                                // Call only when space character is in lesson
                                if (_clsLessonCoach.CorrectWordCount > 0 || _clsLessonCoach.IncorrectWordCount > 0)
                                {
                                    DisplayWordStatus();
                                }
                            }


                            this.GetTypedLetterHighlighted(e.KeyChar);
                            this.ClearTypedLetterHighlighted();
                            int countRowLength = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements.Length;
                            if (countRowLength > _clsLessonCoach.x + 1)
                            {
                                char nextChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x + 1];
                                GetNextTypedLetterHighlighted(nextChar);
                            }
                            //========================================

                            _clsLessonCoach.InputMatch = true;
                            _clsLessonCoach.CorrectCharacterCount += 1;

                            IsLessonStarted = true;
                            //btnStartLessonTyping.Enabled = false;
                            //btnStartLessonTyping.BackColor = Color.Gray;
                        }
                        else
                        {
                            //==================================wrong
                            if (GlobalVarManager.ForgiveErrors)
                            {
                                if (
                                   mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString() ==
                                   " ")
                                {
                                    //if (_clsLessonCoach.CorrectCharacterCount != 1) //Because of A is letter also word
                                    if (_clsLessonCoach.CorrectCharacterCount >= 1)
                                    {
                                        if (currentWrongCount == 0)
                                        {
                                            _clsLessonCoach.CorrectWordCount += 1;
                                        }
                                        else
                                        {
                                            _clsLessonCoach.IncorrectWordCount += 1;
                                        }
                                    }
                                    currentWrongCount = 0;

                                    // Call only when space character is in lesson
                                    if (_clsLessonCoach.CorrectWordCount > 0 || _clsLessonCoach.IncorrectWordCount > 0)
                                    {
                                        DisplayWordStatus();
                                    }
                                }
                            }

                            LblFromStudentGivenAnsList[_clsLessonCoach.x].BackColor = Color.HotPink;

                            //check lowere upper
                            bool sameCharacter = false;
                            if (mdlAPI.studentInputX[_clsLessonCoach.x].ToString().ToLower() ==
                                mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString().ToLower())
                            {
                                sameCharacter = true;
                            }
                            //check lowere upper
                            this.ClearTypedLetterHighlighted();
                            this.GetWrongTypedLetterHighlighted(e.KeyChar, sameCharacter);

                            //for Next character
                            int countRowLength = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements.Length;
                            if (GlobalVarManager.ForgiveErrors)
                            {
                                if (countRowLength > _clsLessonCoach.x + 1)
                                {
                                    char nextChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x + 1];
                                    GetNextTypedLetterHighlighted(nextChar);
                                }
                                else
                                {
                                    this.ClearTypedLetterHighlighted();
                                }
                            }
                            else
                            {
                                if (countRowLength >= _clsLessonCoach.x + 1)
                                {
                                    char nextChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                                    GetNextTypedLetterHighlighted(nextChar);
                                }
                            }
                            //for Next character

                            _clsLessonCoach.InputMatch = false; // a flag for a miss
                            _clsLessonCoach.IncorrectCharacterCount += 1;
                            // counter that keeps track of in-correct input
                            //When next lesson character is space in lesson then if press wrong key then 
                            //show wrong only character not word
                            if (mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString() != " ")
                            {
                                currentWrongCount++;
                            }

                            if (GlobalVarManager.StopCursorOnError)
                            {
                                return;
                            }
                            //==================================


                            //_clsLessonCoach.InputMatch = false;
                            //_clsLessonCoach.IncorrectCharacterCount += 1;
                        }

                        // this char is then read from the studentInputX[] array to the custom-made display (named, FromStudent8)
                        _clsLessonCoach.displayStudentInputX(LblFromStudentGivenAnsList);

                        try
                        {
                            typingProgressBar.Value++;
                        }
                        catch { }

                        //if (!typingIsStart)
                        //_clsDisplay.clearDisplay(LblUpperTitleMsgList);
                        lblUpperTitleMsg.Text = "";
                        // this top yellow custom-made display is cleared


                        if (_clsLessonCoach.x < mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements.Length)
                        {
                            // check to see if end of current row has been reached by student
                            // reads ahead to see what character next has to be duplicated by student, and corresponding to that
                            // accesses the array guideX[] holding the contents of the file guideX1.txt. Based on the ascii value of the charcater to
                            // be duplicated next, the appropriate message from the guideX[] array is displayed on the top yellow display (called msg0)
                            _clsDisplay.displayTheMessage(
                                mdlAPI.guideX[
                                    Convert.ToInt32(
                                        mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x + 1])],
                                lblUpperTitleMsg); // ++++++8+
                        }
                        KeyStillPressed = true;
                        // flag that has been defined elsewhere to ignore auto-repeat that would usually happen on a PC
                        // when a certain key is kept pressed for a little longer than normal
                        _clsLessonCoach.SetState();
                        // recall this is a method defined in the lesson coach class to determine one of 3 states during a typing drill
                        switch (_clsLessonCoach.stateX)
                        {
                            // review SetState() method and the variable stateX both defined inside lesson coach class

                            case 0:
                                {
                                    break;
                                }
                            case 1:
                                {
                                    // this signals beginning of next row
                                    _clsLessonCoach.clearDisplayFromCoach(LblFromCoachLessonList);
                                    _clsLessonCoach.clearDisplayFromStudent(LblFromStudentGivenAnsList);
                                    _clsLessonCoach.displayNewLesson(LblFromCoachLessonList, currentLessonFontSize);
                                    _clsDisplay.displayTheMessage(
                                        mdlAPI.guideX[
                                            Convert.ToInt32(
                                                mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x + 1])
                                            ], lblUpperTitleMsg);
                                    // check/confirm if above line really needed
                                    break;
                                }
                            case 2:
                                {
                                    // this signals end of current lesson
                                    _clsLessonCoach.clearDisplayFromCoach(LblFromCoachLessonList);
                                    _clsLessonCoach.clearDisplayFromStudent(LblFromStudentGivenAnsList);
                                    _clsLessonCoach.KB_ActiveFlag = false;
                                    _clsDisplay.displayTheMessage("Choose quit, and repeat the drill if necessary.",
                                        lblUpperTitleMsg);
                                    mdlAPI.Beep(2000, 100);

                                    break;
                                }
                        } //end switch
                    }
                    else
                    {
                        timer3.Enabled = true;
                        // this is for the scenario  AFTER  the first keystroke
                        // this control structure is needed to implement the scheme for ignoring the case with multiple keys pressed simultaneosly
                        // After the first keystroke this check becomes necessary. This check was not required for the scenario prior to the first keystroke
                        if ((mdlAPI.studentInputX[_clsLessonCoach.x - 1] == c) && (KeyStillPressed == true))
                        {
                            return;
                        }
                        else
                        {
                            if (_clsLessonCoach.x > mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements.Length)
                            {
                                _clsLessonCoach.x = 0;
                            }


                            //mdlAPI.studentInputX[_clsLessonCoach.x] = c;
                            if (GlobalVarManager.EnableCapitalLetter)
                            {
                                mdlAPI.studentInputX[_clsLessonCoach.x] = Char.ToUpper(c);
                            }
                            else
                            {
                                mdlAPI.studentInputX[_clsLessonCoach.x] = c;
                            }
                            //only lower case
                            //if (mdlAPI.studentInputX[_clsLessonCoach.x].ToString().ToLower() ==
                            //    mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString()
                            //        .ToLower())

                            if (mdlAPI.studentInputX[_clsLessonCoach.x].ToString() ==
                                mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString())
                            {
                                //========================================

                                if (
                                    mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString() ==
                                    " ")
                                {
                                    //if (_clsLessonCoach.CorrectCharacterCount != 1) //Because of A is letter also word
                                    if (_clsLessonCoach.CorrectCharacterCount >= 1)
                                    {
                                        if (currentWrongCount == 0)
                                        {
                                            _clsLessonCoach.CorrectWordCount += 1;
                                        }
                                        else
                                        {
                                            _clsLessonCoach.IncorrectWordCount += 1;
                                        }
                                    }
                                    currentWrongCount = 0;

                                    // Call only when space character is in lesson
                                    if (_clsLessonCoach.CorrectWordCount > 0 || _clsLessonCoach.IncorrectWordCount > 0)
                                    {
                                        DisplayWordStatus();
                                    }
                                }


                                this.GetTypedLetterHighlighted(e.KeyChar);
                                this.ClearTypedLetterHighlighted();
                                int countRowLength = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements.Length;
                                if (countRowLength > _clsLessonCoach.x + 1)
                                {
                                    char nextChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x + 1];
                                    GetNextTypedLetterHighlighted(nextChar);
                                }
                                //========================================

                                _clsLessonCoach.InputMatch = true;
                                _clsLessonCoach.CorrectCharacterCount += 1;

                                IsLessonStarted = true;
                                //btnStartLessonTyping.Enabled = false;
                                //btnStartLessonTyping.BackColor = Color.Gray;
                            }
                            else
                            {
                                //==================================wrong
                                if (GlobalVarManager.ForgiveErrors)
                                {
                                    if (
                                       mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString() ==
                                       " ")
                                    {
                                        //if (_clsLessonCoach.CorrectCharacterCount != 1) //Because of A is letter also word
                                        if (_clsLessonCoach.CorrectCharacterCount >= 1)
                                        {
                                            if (currentWrongCount == 0)
                                            {
                                                _clsLessonCoach.CorrectWordCount += 1;
                                            }
                                            else
                                            {
                                                _clsLessonCoach.IncorrectWordCount += 1;
                                            }
                                        }
                                        currentWrongCount = 0;

                                        // Call only when space character is in lesson
                                        if (_clsLessonCoach.CorrectWordCount > 0 || _clsLessonCoach.IncorrectWordCount > 0)
                                        {
                                            DisplayWordStatus();
                                        }
                                    }
                                }
                                LblFromStudentGivenAnsList[_clsLessonCoach.x].BackColor = Color.HotPink;

                                //check lowere upper
                                bool sameCharacter = false;
                                if (mdlAPI.studentInputX[_clsLessonCoach.x].ToString().ToLower() ==
                                    mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString().ToLower())
                                {
                                    sameCharacter = true;
                                }
                                //check lowere upper
                                this.ClearTypedLetterHighlighted();
                                this.GetWrongTypedLetterHighlighted(e.KeyChar, sameCharacter);

                                //for Next character
                                int countRowLength = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements.Length;
                                if (GlobalVarManager.ForgiveErrors)
                                {
                                    if (countRowLength > _clsLessonCoach.x + 1)
                                    {
                                        char nextChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x + 1];
                                        GetNextTypedLetterHighlighted(nextChar);
                                    }
                                    else
                                    {
                                        this.ClearTypedLetterHighlighted();
                                    }
                                }
                                else
                                {
                                    if (countRowLength >= _clsLessonCoach.x + 1)
                                    {
                                        char nextChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                                        GetNextTypedLetterHighlighted(nextChar);
                                    }
                                }
                                //for Next character

                                _clsLessonCoach.InputMatch = false; // a flag for a miss
                                _clsLessonCoach.IncorrectCharacterCount += 1;
                                // counter that keeps track of in-correct input
                                //When next lesson character is space in lesson then if press wrong key then show wrong only character not word
                                if (mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x].ToString() != " ")
                                {
                                    currentWrongCount++;
                                }

                                if (GlobalVarManager.StopCursorOnError)
                                {
                                    return;
                                }
                                //==================================


                                //_clsLessonCoach.InputMatch = false;
                                //_clsLessonCoach.IncorrectCharacterCount += 1;
                            }

                            // this char is then read from the studentInputX[] to the student display (lblFromStudent)
                            _clsLessonCoach.displayStudentInputX(LblFromStudentGivenAnsList);
                            lblUpperTitleMsg.Text = "";

                            if (_clsLessonCoach.x < mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements.Length - 1)
                            {
                                _clsDisplay.displayTheMessage(
                                    mdlAPI.guideX[
                                        Convert.ToInt32(
                                            mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x + 1])
                                        ], lblUpperTitleMsg); // ++++++8+
                            }
                            try
                            {
                                typingProgressBar.Value++;
                            }
                            catch { }
                            KeyStillPressed = true;
                            _clsLessonCoach.SetState();
                            switch (_clsLessonCoach.stateX)
                            {
                                case 0:
                                    {
                                        break;
                                    }
                                case 1:
                                    {
                                        // this signals beginning of next row
                                        LineTyped += 1; // Counts Number of Lines Typed
                                        _clsLessonCoach.clearDisplayFromCoach(LblFromCoachLessonList);
                                        _clsLessonCoach.clearDisplayFromStudent(LblFromStudentGivenAnsList);
                                        _clsLessonCoach.displayNewLesson(LblFromCoachLessonList, currentLessonFontSize);
                                        _clsDisplay.displayTheMessage(
                                            mdlAPI.guideX[
                                                Convert.ToInt32(
                                                    mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x])
                                                ], lblUpperTitleMsg);
                                        break;
                                    }
                                case 2:
                                    {
                                        // this signals end of current lesson
                                        // make timer ON to show endinf flash text
                                        timer2.Enabled = true;
                                        _clsLessonCoach.clearDisplayFromCoach(LblFromCoachLessonList);
                                        _clsLessonCoach.clearDisplayFromStudent(LblFromStudentGivenAnsList);
                                        //_clsLessonCoach.KB_ActiveFlag = false;//Arif
                                        _clsDisplay.displayTheMessage("Choose quit, and repeat the drill if necessary.", lblUpperTitleMsg);
                                        mdlAPI.Beep(2000, 100);
                                        timer3.Enabled = false;

                                        //at the end of current lesson everything will be reset.


                                        string currentTime = lblTime.Text;
                                        string[] timeSplit = currentTime.Split(new char[] { ':' });

                                        int hour = int.Parse(timeSplit[0]);
                                        int minute = int.Parse(timeSplit[1]);
                                        int second = int.Parse(timeSplit[2]);

                                        int totalSecond = (hour * 60 * 60) + (minute * 60) + second;
                                        decimal totalMinute = Convert.ToDecimal(totalSecond) / 60;
                                        decimal totalHour = Convert.ToDecimal(totalMinute) / 60;

                                        //Character Per Minute
                                        int totalCharacter = _clsLessonCoach.CorrectCharacterCount;
                                        decimal charPerMin = Math.Ceiling(totalCharacter / totalMinute);
                                        //var totalCharPerMin = Math.Ceiling(charPerMin);

                                        //Word Per Minute 
                                        int totalWord = _clsLessonCoach.CorrectWordCount + _clsLessonCoach.IncorrectWordCount;
                                        decimal wordPerMin = Math.Ceiling(totalWord / totalMinute);


                                        qSecond = 0;
                                        qMinute = 0;
                                        qHour = 0;
                                        lblTime.Text = qHour.ToString() + @" : " + qMinute.ToString() + @" : " + qSecond.ToString();
                                        _clsDisplay.ClearDisplayText(LblFromCoachLessonList);
                                        _clsDisplay.ClearDisplayText(LblFromStudentGivenAnsList);


                                        //lesson chages
                                        //IsLessonStarted = false;//Arif
                                        //btnStartLessonTyping.Enabled = true;
                                        //btnStartLessonTyping.BackColor = Color.FromArgb(223, 217, 217);

                                        DisplayCharacterStatus();
                                        DisplayWordStatus();
                                        DisplayProgressBarPercentage();



                                        _clsLessonCoach.activeRow = 0;
                                        //currentLessonPathName = string.Empty; //Arif
                                        typingProgressBar.Value = 0;

                                        this.ClearTypedLetterHighlighted();

                                        //Character Reset
                                        _clsLessonCoach.CorrectCharacterCount = 0;
                                        _clsLessonCoach.IncorrectCharacterCount = 0;
                                        //Word Reset
                                        _clsLessonCoach.CorrectWordCount = 0;
                                        _clsLessonCoach.IncorrectWordCount = 0;

                                        //string currentLessonEndMessage = "this is end of current lesson, to practice another lesson select another lesson. ";
                                        //MessageBox.Show(currentLessonEndMessage, @"Select another lesson", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        string currentLessonEndMessage = "This is end of current lesson, to continue select another one.";
                                        MessageBox.Show(currentLessonEndMessage, @" ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;

                                    }
                            } //end switch
                        }
                    }
                } //end key stroke process
            }


            // time to update score on the bottom yellow display called msg1
            if (_clsLessonCoach.CorrectCharacterCount > 0)
            {
                DisplayCharacterStatus();
            }

            //if (_clsLessonCoach.CorrectWordCount > 0) //Because of if incorrect word then also show this score
            //if (_clsLessonCoach.CorrectWordCount > 0 || _clsLessonCoach.IncorrectWordCount>0 )
            //{
            //    DisplayWordStatus();
            //}


            DisplayProgressBarPercentage();
        }

        private void DisplayCharacterStatus()
        {
            //Character Score with percentag
            _clsDisplay.displayTheMessage(
                "Your Character Score: " +
                (Convert.ToInt16(((Convert.ToSingle(_clsLessonCoach.CorrectCharacterCount) /
                                   Convert.ToSingle(Convert.ToSingle(_clsLessonCoach.IncorrectCharacterCount) +
                                                    Convert.ToSingle(_clsLessonCoach.CorrectCharacterCount))) * 100)))
                    .ToString() + "% Correct  (" + (_clsLessonCoach.CorrectCharacterCount).ToString() + " Right / " +
                (_clsLessonCoach.IncorrectCharacterCount).ToString() + " Wrong)", lblCharacterScoreMsg);

            //Character Per minute 

            string currentTime = lblTime.Text;
            string[] timeSplit = currentTime.Split(new char[] { ':' });

            int hour = int.Parse(timeSplit[0]);
            int minute = int.Parse(timeSplit[1]);
            int second = int.Parse(timeSplit[2]);

            int totalSecond = (hour * 60 * 60) + (minute * 60) + second;
            decimal totalMinute = Convert.ToDecimal(totalSecond) / 60;
            decimal totalHour = Convert.ToDecimal(totalMinute) / 60;

            int totalCharacter = _clsLessonCoach.CorrectCharacterCount;
            if (totalCharacter != 0 && totalMinute != 0)
            {
                decimal charPerMin = Math.Ceiling(totalCharacter / totalMinute);
                string message = "Character Perminute: " + charPerMin + " Total " + Math.Round(totalMinute, 2) + " Minute Taken";
                lblCharPerMin.Text = "";
                _clsDisplay.DispalyCharacterPerminScore(message, lblCharPerMin);
            }
        }

        private void DisplayWordStatus()
        {
            //Word Score with percentage
            _clsDisplay.DispalyWordWiseScore(
                "Your Word Score: " + Convert.ToInt16((Convert.ToSingle(_clsLessonCoach.CorrectWordCount)
                                                       /
                                                       Convert.ToSingle(
                                                           Convert.ToSingle(_clsLessonCoach.IncorrectWordCount) +
                                                           Convert.ToSingle(_clsLessonCoach.CorrectWordCount))) * 100)
                    .ToString()
                + "% Correct " + "" + " (" + _clsLessonCoach.CorrectWordCount.ToString() + " Right / " +
                _clsLessonCoach.IncorrectWordCount.ToString() + " Wrong)"
                ,
                lblWordScoreMsg);

            //Word per Minute
            string currentTime = lblTime.Text;
            string[] timeSplit = currentTime.Split(new char[] { ':' });

            int hour = int.Parse(timeSplit[0]);
            int minute = int.Parse(timeSplit[1]);
            int second = int.Parse(timeSplit[2]);

            int totalSecond = (hour * 60 * 60) + (minute * 60) + second;
            decimal totalMinute = Convert.ToDecimal(totalSecond) / 60;
            decimal totalHour = Convert.ToDecimal(totalMinute) / 60;

            int totalWord = _clsLessonCoach.CorrectWordCount + _clsLessonCoach.IncorrectWordCount;

            if (totalWord != 0 && totalMinute != 0)
            {
                decimal wordPerMin = Math.Ceiling(totalWord / totalMinute);
                string message = "Word Perminute: " + wordPerMin + " Total " + Math.Round(totalMinute, 2) + " Minute Taken";
                lblWordPerMin.Text = "";
                _clsDisplay.DispalyCharacterPerminScore(message, lblWordPerMin);
            }
        }

        private void DisplayProgressBarPercentage()
        {
            if (typingProgressBar.Value > 0)
            {
                var max = typingProgressBar.Maximum;
                int val = typingProgressBar.Value;
                decimal per = Convert.ToDecimal(val) / max;

                lblProgressBarPercentage.Text = "Progress  " + Math.Ceiling(Math.Round(Math.Ceiling(per * 100))).ToString() + "%";
                lblProgressBarPercentage.BackColor = Color.FromArgb(239, 255, 215);
            }
            else
            {
                lblProgressBarPercentage.Text = "Progress 0 %";
                lblProgressBarPercentage.BackColor = Color.FromArgb(239, 255, 215);
            }
        }

        #region KeyPressed Keyboard Highlighted

        private void GetWrongTypedLetterHighlighted(char pressedChar, bool sameCharacter)
        {
            WrongKeySound();
            if (sameCharacter)
            {
                btnShiftLeft.BackColor = Color.Red;
                return;
            }
            switch (Char.ToLower(pressedChar))
            {
                case 'a':
                    btnA.BackColor = Color.Red;
                    break;
                case 'b':
                    btnB.BackColor = Color.Red;
                    break;
                case 'c':
                    btnC.BackColor = Color.Red;
                    break;
                case 'd':
                    btnD.BackColor = Color.Red;
                    break;
                case 'e':
                    btnE.BackColor = Color.Red;
                    break;
                case 'f':
                    btnF.BackColor = Color.Red;
                    break;
                case 'g':
                    btnG.BackColor = Color.Red;
                    break;
                case 'h':
                    btnH.BackColor = Color.Red;
                    break;
                case 'i':
                    btnI.BackColor = Color.Red;
                    break;
                case 'j':
                    btnJ.BackColor = Color.Red;
                    break;
                case 'k':
                    btnK.BackColor = Color.Red;
                    break;
                case 'l':
                    btnL.BackColor = Color.Red;
                    break;
                case 'm':
                    btnM.BackColor = Color.Red;
                    break;
                case 'n':
                    btnN.BackColor = Color.Red;
                    break;
                case 'o':
                    btnO.BackColor = Color.Red;
                    break;
                case 'p':
                    btnP.BackColor = Color.Red;
                    break;
                case 'q':
                    btnQ.BackColor = Color.Red;
                    break;
                case 'r':
                    btnR.BackColor = Color.Red;
                    break;
                case 's':
                    btnS.BackColor = Color.Red;
                    break;
                case 't':
                    btnT.BackColor = Color.Red;
                    break;
                case 'u':
                    btnU.BackColor = Color.Red;
                    break;
                case 'v':
                    btnV.BackColor = Color.Red;
                    break;
                case 'w':
                    btnW.BackColor = Color.Red;
                    break;
                case 'x':
                    btnX.BackColor = Color.Red;
                    break;
                case 'y':
                    btnY.BackColor = Color.Red;
                    break;
                case 'z':
                    btnZ.BackColor = Color.Red;
                    break;
                case '1':
                case '!':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btn1Exclamation.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '1' || currentChar == '!')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btn1Exclamation.BackColor = Color.Red;
                        break;
                    }
                case '2':
                case '@':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btn2AtTheRate.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '2' || currentChar == '@')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btn2AtTheRate.BackColor = Color.Red;
                        break;
                    }
                case '3':
                case '#':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btn3Hash.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '3' || currentChar == '#')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btn3Hash.BackColor = Color.Red;
                        break;
                    }
                case '4':
                case '$':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btn4Dollar.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '4' || currentChar == '$')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btn4Dollar.BackColor = Color.Red;
                        break;
                    }
                case '5':
                case '%':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btn5Percentage.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '5' || currentChar == '%')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btn5Percentage.BackColor = Color.Red;
                        break;
                    }
                case '6':
                case '^':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btn6Caret.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '6' || currentChar == '^')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btn6Caret.BackColor = Color.Red;
                        break;
                    }
                case '7':
                case '&':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btn7And.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '7' || currentChar == '&')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btn7And.BackColor = Color.Red;
                        break;
                    }
                case '8':
                case '*':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btn8Star.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '8' || currentChar == '*')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btn8Star.BackColor = Color.Red;
                        break;
                    }
                case '9':
                case '(':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btn9OpenParenthesis.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '9' || currentChar == '(')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btn9OpenParenthesis.BackColor = Color.Red;
                        break;
                    }
                case '0':
                case ')':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btn0CloseParenthesis.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '0' || currentChar == ')')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btn0CloseParenthesis.BackColor = Color.Red;
                        break;
                    }
                case '`':
                case '~':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnTildeAcute.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '`' || currentChar == '~')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnTildeAcute.BackColor = Color.Red;
                        break;
                    }
                case '-':
                case '_':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnHypenUnderScore.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '-' || currentChar == '_')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnHypenUnderScore.BackColor = Color.Red;
                        break;
                    }
                case '=':
                case '+':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnPlusEquals.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '=' || currentChar == '+')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnPlusEquals.BackColor = Color.Red;
                        break;
                    }
                case '[':
                case '{':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnSecondThirdOpen.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '[' || currentChar == '{')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnSecondThirdOpen.BackColor = Color.Red;
                        break;
                    }
                case ']':
                case '}':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnSecondThirdClose.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == ']' || currentChar == '}')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnSecondThirdClose.BackColor = Color.Red;
                        break;
                    }
                case ':':
                case ';':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnColonSemiColon.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == ':' || currentChar == ';')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnColonSemiColon.BackColor = Color.Red;
                        break;
                    }
                case '\'':
                case '"':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnQuotation.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '\'' || currentChar == '"')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnQuotation.BackColor = Color.Red;
                        break;
                    }
                case '\\':
                case '|':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnPipeForwardSlash.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '\\' || currentChar == '|')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnPipeForwardSlash.BackColor = Color.Red;
                        break;
                    }
                case ',':
                case '<':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnLessThanComma.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == ',' || currentChar == '<')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnLessThanComma.BackColor = Color.Red;
                        break;
                    }
                case '.':
                case '>':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnGreaterThanFullStop.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '.' || currentChar == '>')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnGreaterThanFullStop.BackColor = Color.Red;
                        break;
                    }
                case '/':
                case '?':
                    {
                        //if (frmMain.StopCursorOnError)
                        //btnQuestionMarkBackSlash.BackColor = Color.Red;
                        char currentChar = mdlAPI.lessonX[_clsLessonCoach.activeRow].arrElements[_clsLessonCoach.x];
                        if (currentChar == '/' || currentChar == '?')
                        {
                            btnShiftLeft.BackColor = Color.Red;
                        }
                        else
                            btnQuestionMarkBackSlash.BackColor = Color.Red;

                        break;
                    }
                case ' ':
                    btnSpaceBar.BackColor = Color.Red;
                    break;
            }
        }

        private void GetNextTypedLetterHighlighted(char pressedChar)
        {
            switch (Char.ToLower(pressedChar))
            {
                case 'a':
                    btnA.BackColor = Color.Green;
                    break;
                case 'b':
                    btnB.BackColor = Color.Green;
                    break;
                case 'c':
                    btnC.BackColor = Color.Green;
                    break;
                case 'd':
                    btnD.BackColor = Color.Green;
                    break;
                case 'e':
                    btnE.BackColor = Color.Green;
                    break;
                case 'f':
                    btnF.BackColor = Color.Green;
                    break;
                case 'g':
                    btnG.BackColor = Color.Green;
                    break;
                case 'h':
                    btnH.BackColor = Color.Green;
                    break;
                case 'i':
                    btnI.BackColor = Color.Green;
                    break;
                case 'j':
                    btnJ.BackColor = Color.Green;
                    break;
                case 'k':
                    btnK.BackColor = Color.Green;
                    break;
                case 'l':
                    btnL.BackColor = Color.Green;
                    break;
                case 'm':
                    btnM.BackColor = Color.Green;
                    break;
                case 'n':
                    btnN.BackColor = Color.Green;
                    break;
                case 'o':
                    btnO.BackColor = Color.Green;
                    break;
                case 'p':
                    btnP.BackColor = Color.Green;
                    break;
                case 'q':
                    btnQ.BackColor = Color.Green;
                    break;
                case 'r':
                    btnR.BackColor = Color.Green;
                    break;
                case 's':
                    btnS.BackColor = Color.Green;
                    break;
                case 't':
                    btnT.BackColor = Color.Green;
                    break;
                case 'u':
                    btnU.BackColor = Color.Green;
                    break;
                case 'v':
                    btnV.BackColor = Color.Green;
                    break;
                case 'w':
                    btnW.BackColor = Color.Green;
                    break;
                case 'x':
                    btnX.BackColor = Color.Green;
                    break;
                case 'y':
                    btnY.BackColor = Color.Green;
                    break;
                case 'z':
                    btnZ.BackColor = Color.Green;
                    break;
                case '1':
                case '!':
                    btn1Exclamation.BackColor = Color.Green;
                    break;
                case '2':
                case '@':
                    btn2AtTheRate.BackColor = Color.Green;
                    break;
                case '3':
                case '#':
                    btn3Hash.BackColor = Color.Green;
                    break;
                case '4':
                case '$':
                    btn4Dollar.BackColor = Color.Green;
                    break;
                case '5':
                case '%':
                    btn5Percentage.BackColor = Color.Green;
                    break;
                case '6':
                case '^':
                    btn6Caret.BackColor = Color.Green;
                    break;
                case '7':
                case '&':
                    btn7And.BackColor = Color.Green;
                    break;
                case '8':
                case '*':
                    btn8Star.BackColor = Color.Green;
                    break;
                case '9':
                case '(':
                    btn9OpenParenthesis.BackColor = Color.Green;
                    break;
                case '0':
                case ')':
                    btn0CloseParenthesis.BackColor = Color.Green;
                    break;
                case '`':
                case '~':
                    btnTildeAcute.BackColor = Color.Green;
                    break;
                case '-':
                case '_':
                    btnHypenUnderScore.BackColor = Color.Green;
                    break;
                case '=':
                case '+':
                    btnPlusEquals.BackColor = Color.Green;
                    break;
                case '[':
                case '{':
                    btnSecondThirdOpen.BackColor = Color.Green;
                    break;
                case ']':
                case '}':
                    btnSecondThirdClose.BackColor = Color.Green;
                    break;
                case ':':
                case ';':
                    btnColonSemiColon.BackColor = Color.Green;
                    break;
                case '\'':
                case '"':
                    btnQuotation.BackColor = Color.Green;
                    break;
                case '\\':
                case '|':
                    btnPipeForwardSlash.BackColor = Color.Green;
                    break;
                case ',':
                case '<':
                    btnLessThanComma.BackColor = Color.Green;
                    break;
                case '.':
                case '>':
                    btnGreaterThanFullStop.BackColor = Color.Green;
                    break;
                case '/':
                case '?':
                    btnQuestionMarkBackSlash.BackColor = Color.Green;
                    break;
                case ' ':
                    btnSpaceBar.BackColor = Color.Green;
                    break;
            }
        }
        private void GetTypedLetterHighlighted(char pressedChar)
        {
            CorrectKeySound();
            //ClearTypedLetterHighlighted();
            switch (Char.ToLower(pressedChar))
            {
                case 'a':
                    btnA.BackColor = Color.FromArgb(66, 64, 62);
                    //btnA.BackColor = Color.Gray;
                    break;
                case 'b':
                    btnB.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'c':
                    btnC.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'd':
                    btnD.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'e':
                    btnE.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'f':
                    btnF.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'g':
                    btnG.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'h':
                    btnH.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'i':
                    btnI.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'j':
                    btnJ.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'k':
                    btnK.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'l':
                    btnL.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'm':
                    btnM.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'n':
                    btnN.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'o':
                    btnO.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'p':
                    btnP.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'q':
                    btnQ.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'r':
                    btnR.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 's':
                    btnS.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 't':
                    btnT.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'u':
                    btnU.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'v':
                    btnV.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'w':
                    btnW.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'x':
                    btnX.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'y':
                    btnY.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case 'z':
                    btnZ.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '1':
                case '!':
                    btn1Exclamation.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '2':
                case '@':
                    btn2AtTheRate.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '3':
                case '#':
                    btn3Hash.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '4':
                case '$':
                    btn4Dollar.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '5':
                case '%':
                    btn5Percentage.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '6':
                case '^':
                    btn6Caret.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '7':
                case '&':
                    btn7And.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '8':
                case '*':
                    btn8Star.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '9':
                case '(':
                    btn9OpenParenthesis.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '0':
                case ')':
                    btn0CloseParenthesis.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '`':
                case '~':
                    btnTildeAcute.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '-':
                case '_':
                    btnHypenUnderScore.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '=':
                case '+':
                    btnPlusEquals.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '[':
                case '{':
                    btnSecondThirdOpen.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case ']':
                case '}':
                    btnSecondThirdClose.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case ':':
                case ';':
                    btnColonSemiColon.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '\'':
                case '"':
                    btnQuotation.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '\\':
                case '|':
                    btnPipeForwardSlash.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case ',':
                case '<':
                    btnLessThanComma.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '.':
                case '>':
                    btnGreaterThanFullStop.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case '/':
                case '?':
                    btnQuestionMarkBackSlash.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case ' ':
                    btnSpaceBar.BackColor = Color.FromArgb(66, 64, 62);
                    break;
            }
        }

        //private void ClearTypedLetterHighlighted()
        //{
        //    btnA.BackColor =
        //    btnB.BackColor =
        //    btnC.BackColor =
        //    btnD.BackColor =
        //    btnE.BackColor =
        //    btnF.BackColor =
        //    btn6Caret.BackColor =
        //    btn7And.BackColor =
        //    btn8Star.BackColor =
        //    btn9OpenParenthesis.BackColor =
        //    btn0CloseParenthesis.BackColor =
        //    btn5Percentage.BackColor =
        //    btnZ.BackColor =
        //    btn1Exclamation.BackColor =
        //    btn2AtTheRate.BackColor =
        //    btn3Hash.BackColor =
        //    btn4Dollar.BackColor =
        //    btnY.BackColor =
        //    btnT.BackColor =
        //    btnU.BackColor =
        //    btnV.BackColor =
        //    btnW.BackColor =
        //    btnX.BackColor =
        //    btnS.BackColor =
        //    btnN.BackColor =
        //    btnO.BackColor =
        //    btnP.BackColor =
        //    btnQ.BackColor =
        //    btnR.BackColor =
        //    btnM.BackColor =
        //    btnH.BackColor =
        //    btnI.BackColor =
        //    btnJ.BackColor =
        //    btnK.BackColor =
        //    btnL.BackColor =
        //    btnG.BackColor =
        //    btnTab.BackColor =
        //    btnCapsLock.BackColor =
        //    btnShiftLeft.BackColor =
        //    btnColonSemiColon.BackColor =
        //    btnShiftRight.BackColor =
        //    btnCtrlRight.BackColor =
        //    btnAltLeft.BackColor =
        //    btnCtrlLeft.BackColor =
        //    btnAltRight.BackColor =
        //    btnEnter.BackColor =
        //    btnQuotation.BackColor =
        //    btnLessThanComma.BackColor =
        //    btnQuestionMarkBackSlash.BackColor =
        //    btnGreaterThanFullStop.BackColor =
        //    btnTildeAcute.BackColor =
        //    btnSpaceBar.BackColor =
        //    btnHypenUnderScore.BackColor =
        //    btnPlusEquals.BackColor =
        //    btnSecondThirdClose.BackColor =
        //    btnSecondThirdOpen.BackColor =
        //    btnPipeForwardSlash.BackColor =
        //    btnBackSpace.BackColor =
        //    btnRightwardArrow.BackColor =
        //    btnNumEnter.BackColor =
        //    btnNumPlus.BackColor =
        //    btnNumMinus.BackColor =
        //    btnNumDel.BackColor =
        //    btnNum3.BackColor =
        //    btnNum6.BackColor =
        //    btnNum9.BackColor =
        //    btnNumZeroInsert.BackColor =
        //    btnNumMultiply.BackColor =
        //    btnNum2.BackColor =
        //    btnDownWardArrow.BackColor =
        //    btnNum5.BackColor =
        //    btnNum8.BackColor =
        //    btnUpwardArrow.BackColor =
        //    btnNumDivide.BackColor =
        //    btnNum1.BackColor =
        //    btnLeftwardArrow.BackColor =
        //    btnNum4.BackColor =
        //    btnNum7.BackColor =
        //    btnPageUp.BackColor =
        //    btnNumlock.BackColor =
        //    btnHome.BackColor =
        //    btnInsert.BackColor =
        //    btnPageDown.BackColor =
        //    btnEnd.BackColor =
        //    btnDelete.BackColor =
        //    Color.FromArgb(223, 217, 217);
        //    LoadKeyColor();
        //}

        public void ClearTypedLetterHighlighted()
        {
            btnNumEnter.BackColor =
            btnNumPlus.BackColor =
            btnNumMinus.BackColor =
            btnSecondThirdClose.BackColor =
            btnSecondThirdOpen.BackColor =
            btnHypenUnderScore.BackColor =
            btnPlusEquals.BackColor =
            btn0CloseParenthesis.BackColor =
            btnQuestionMarkBackSlash.BackColor =
            btnP.BackColor =
            btnQuotation.BackColor =
            btnColonSemiColon.BackColor =
            Color.FromArgb(118, 192, 67);

            btnNumDel.BackColor =
            btnNum3.BackColor =
            btnNum6.BackColor =
            btnNum9.BackColor =
            btnNumMultiply.BackColor = System.Drawing.Color.FromArgb(66, 158, 209);

            btnNum2.BackColor =
            btnNum5.BackColor =
            btnNum8.BackColor =
            btnNumDivide.BackColor = System.Drawing.Color.FromArgb(236, 86, 124);

            btnDownWardArrow.BackColor =
            btnRightwardArrow.BackColor =
            btnUpwardArrow.BackColor =
            btnLeftwardArrow.BackColor =
            btnPageDown.BackColor =
            btnPageUp.BackColor =
            btnEnd.BackColor =
            btnDelete.BackColor =
            btnHome.BackColor =
            btnInsert.BackColor = System.Drawing.Color.FromArgb(223, 217, 217);

            btnNum1.BackColor =
            btnNumZeroInsert.BackColor =
            btnNum4.BackColor =
            btnNum7.BackColor =
            btnNumlock.BackColor = System.Drawing.Color.FromArgb(104, 94, 197);

            btn7And.BackColor =
            btnY.BackColor =
            btnU.BackColor =
            btnN.BackColor =
            btnM.BackColor =
            btnH.BackColor =
            btnJ.BackColor = System.Drawing.Color.FromArgb(104, 94, 198);

            btnShiftRight.BackColor =
            btnEnter.BackColor =
            btnBackSpace.BackColor =
            btnBackSpace.BackColor =
            btnPipeForwardSlash.BackColor = System.Drawing.Color.FromArgb(244, 173, 91);

            btnTildeAcute.BackColor =
            btnSpaceBar.BackColor =
            btnShiftLeft.BackColor =
            btnCapsLock.BackColor =
            btnTab.BackColor = System.Drawing.Color.FromArgb(236, 177, 87);

            btnLessThanComma.BackColor =
            btn8Star.BackColor =
            btnI.BackColor =
            btnK.BackColor = System.Drawing.Color.FromArgb(234, 85, 123);

            btnCtrlRight.BackColor =
            btnAltRight.BackColor =
            btnAltLeft.BackColor =
            btnCtrlLeft.BackColor = System.Drawing.Color.FromArgb(248, 249, 249);

            btnGreaterThanFullStop.BackColor =
            btn9OpenParenthesis.BackColor =
            btnL.BackColor =
            btnO.BackColor = System.Drawing.Color.FromArgb(66, 161, 210);

            btnZ.BackColor =
            btn1Exclamation.BackColor =
            btn2AtTheRate.BackColor =
            btnQ.BackColor =
            btnA.BackColor = System.Drawing.Color.FromArgb(184, 68, 131);

            btn3Hash.BackColor =
            btnW.BackColor =
            btnX.BackColor =
            btnS.BackColor = System.Drawing.Color.FromArgb(68, 192, 237);

            btn5Percentage.BackColor =
            btnT.BackColor =
            btnV.BackColor =
            btn6Caret.BackColor =
            btnR.BackColor =
            btnG.BackColor =
            btnB.BackColor =
            btnF.BackColor = System.Drawing.Color.FromArgb(99, 192, 148);

            btnC.BackColor =
            btnD.BackColor =
            btnE.BackColor =
            btn4Dollar.BackColor = System.Drawing.Color.FromArgb(225, 76, 154);

            btnLeftwardArrow.BackColor =
            btnDownWardArrow.BackColor =
            btnRightwardArrow.BackColor =
            btnUpwardArrow.BackColor =
            btnDelete.BackColor =
            btnEnd.BackColor =
            btnPageDown.BackColor =
            btnPageUp.BackColor =
            btnHome.BackColor =
            btnInsert.BackColor =
            btnLeftwardArrow.BackColor =
            btnDownWardArrow.BackColor =
            btnRightwardArrow.BackColor =
            btnUpwardArrow.BackColor =
            btnDelete.BackColor =
            btnEnd.BackColor =
            btnPageDown.BackColor =
            btnPageUp.BackColor =
            btnHome.BackColor =
            btnInsert.BackColor = System.Drawing.Color.FromArgb(53, 68, 111);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys key);

        private void GetNonInputKeyHighlighted(KeyEventArgs e)
        {

            //if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            //{
            //    MessageBox.Show("Pressed " + Keys.Shift);
            //}

            //if (Keys.ShiftKey == Keys.LShiftKey)
            //{
            //    MessageBox.Show("Pressed " + Keys.RShiftKey);
            //}

            //if (e.KeyCode == "VK_LSHIFT")
            //{

            //}

            //if (e.KeyCode == Keys.ShiftKey)
            //{
            //    if (Convert.ToBoolean(GetAsyncKeyState(Keys.LShiftKey)))
            //        btnShiftLeft.BackColor = Color.FromArgb(66, 64, 62);
            //    if (GetAsyncKeyState(Keys.RShiftKey) < 0)
            //        btnShiftRight.BackColor = Color.FromArgb(66, 64, 62);
            //}

            switch (e.KeyData)
            {
                case Keys.Tab:
                    btnTab.BackColor = Color.FromArgb(66, 64, 62);
                    textBox2.Focus();
                    break;
                case Keys.CapsLock:
                    btnCapsLock.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.LShiftKey:
                    btnShiftLeft.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.LControlKey:
                    btnCtrlLeft.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.LMenu:
                    btnAltLeft.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.RMenu:
                    btnAltRight.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.RControlKey:
                    btnCtrlRight.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.RShiftKey:
                    btnShiftRight.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                //case Keys.Enter:
                //    btnEnter.BackColor = Color.FromArgb(66, 64, 62);
                //    break;
                //case Keys.Back:
                //    btnBackSpace.BackColor = Color.FromArgb(66, 64, 62);
                //    break;

                case Keys.Insert:
                    btnInsert.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Home:
                    btnHome.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.PageUp:
                    btnPageUp.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Delete:
                    btnDelete.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.End:
                    btnEnd.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.PageDown:
                    btnPageDown.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Left:
                    btnLeftwardArrow.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Right:
                    btnRightwardArrow.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Up:
                    btnUpwardArrow.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Down:
                    btnDownWardArrow.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Add:
                    btnNumPlus.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Subtract:
                    btnNumMinus.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Multiply:
                    btnNumMultiply.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Divide:
                    btnNumDivide.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumLock:
                    btnNumlock.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumPad0:
                    btnNumZeroInsert.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumPad1:
                    btnNum1.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumPad2:
                    btnNum2.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumPad3:
                    btnNum3.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumPad4:
                    btnNum4.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumPad5:
                    btnNum5.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumPad6:
                    btnNum6.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumPad7:
                    btnNum7.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumPad8:
                    btnNum8.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.NumPad9:
                    btnNum9.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Enter:
                    btnNumEnter.BackColor = Color.FromArgb(66, 64, 62);
                    btnEnter.BackColor = Color.FromArgb(66, 64, 62);
                    break;

                // another methods

                case Keys.ShiftKey:
                    btnShiftRight.BackColor = Color.FromArgb(66, 64, 62);
                    btnShiftLeft.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.Menu:
                    btnAltLeft.BackColor = Color.FromArgb(66, 64, 62);
                    btnAltRight.BackColor = Color.FromArgb(66, 64, 62);
                    break;
                case Keys.ControlKey:

                    const Keys controlKey = Keys.ControlKey;
                    if (controlKey.ToString().Contains("LButton"))
                        btnCtrlLeft.BackColor = Color.FromArgb(66, 64, 62);

                    btnCtrlRight.BackColor = Color.FromArgb(66, 64, 62);
                    break;
            }
        }

        private void GetBackEnterKey(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEnter.BackColor = Color.FromArgb(66, 64, 62);
            }
            else if (e.KeyChar == 8)
            {
                btnBackSpace.BackColor = Color.FromArgb(66, 64, 62);
            }

        }

        #endregion

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            KeyStillPressed = false;

            if (e.KeyData == Keys.CapsLock)
            {
                //Keyboard.offCapsLock();
            }
            if (KeyStillPressed == true)
            {
                GetNonInputKeyHighlighted(e);
            }
        }



        private void textBox2_Leave(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            //textBox2.Focus();
            lbLesson.Focus();
        }

        #region Menu Strip Events

        //private void exitNowToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //Application.Exit();
        //    this.Hide();
        //    frmMain main = new frmMain();
        //    main.ShowDialog();
        //}

        //private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    using (frmAbout dialog = new frmAbout())
        //    {
        //        dialog.ShowDialog(this);
        //    }
        //}

        #endregion

        #region Timer Events
        //Starting time show message before any button click
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (t > 4) t = 0; // flashing only 4 lines
                //clear display
                //if (!typingIsStart)
                //_clsDisplay.clearDisplay(LblUpperTitleMsgList);
                lblUpperTitleMsg.Text = "";
                //display flash texts
                _clsDisplay.displayTheMessage(mdlAPI.FlashText[t], lblUpperTitleMsg);
                t++;
            }
            catch (Exception)
            {
                t = 0;

            }


        }

        //When lesson close then thank you message show
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (t2 > 1) t2 = 0; // flashing only 2 lines
                //clear display
                //if (!typingIsStart)
                //_clsDisplay.clearDisplay(LblUpperTitleMsgList);
                lblUpperTitleMsg.Text = "";
                //display flash texts
                _clsDisplay.displayTheMessage(mdlAPI.EndFlashText[t2], lblUpperTitleMsg);
                t2++;
            }
            catch (Exception)
            {

                t2 = 0;
            }


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            qSecond++;

            if (qSecond == 60)
            {
                qMinute++;
                qSecond = 0;
            }

            if (qMinute == 60)
            {
                qHour++;
                qMinute = 0;
            }
            lblTime.Text = qHour.ToString() + " : " + qMinute.ToString() + " : " + qSecond.ToString();
        }


        #endregion

        #region Media Player Events

        private void Image1_Click(object sender, EventArgs e)
        {
            string directoryPath = Application.StartupPath + "\\Music";
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);

            openFileDialog1.FileName = dirInfo.FullName;
            openFileDialog1.Filter =
                "Mpeg Audio Layer3 (*.mp3)|*.mp3|Mpeg 4 (*.mp4)|*.mp4|Windows Media Video (*.wmv)|*.wmv|(*.avi)|*.avi|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName.Trim() != "")
                MP.URL = openFileDialog1.FileName;

        }

        private void MP_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            textBox2.Focus();
        }

        private void MP_StatusChange(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void MP_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            textBox2.Focus();
        }

        private void MP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            textBox2.Focus();
        }

        private void MP_Enter(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        #endregion

        public void LoadAllLessons()
        {
            List<DirectoryFiles> dirFileList = new List<DirectoryFiles>();
            string directoryPath = Application.StartupPath + "\\tt\\PracticeLessons\\Word";
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
            FileInfo[] fileInfos = dirInfo.GetFiles();
            foreach (FileInfo fileInfo in fileInfos)
            {
                DirectoryFiles dirFiles = new DirectoryFiles();
                dirFiles.FileName = fileInfo.Name.Substring(0, (fileInfo.Name.Length - Path.GetExtension(fileInfo.Name).Length));
                dirFileList.Add(dirFiles);
            }
            lbLesson.DataSource = dirFileList;
            lbLesson.DisplayMember = "FileName";
            textBox2.Focus();
        }

        private void selectLessonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVarManager.EnabledPageName = "PageWord";
            using (frmPracticeLessionList frmPracticeLessionList = new frmPracticeLessionList())
            {
                frmPracticeLessionList.ShowDialog();
                LoadAllLessons();
            }
        }

        private void handleCapsLockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Text Files | *.txt";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectFileLoc = openFileDialog.FileName;
                    string fileName = Path.GetFileName(selectFileLoc);
                    //string saveFileLocCopy = @"E:\" + fileName;

                    string saveFileLocDirectory = Application.StartupPath + "\\tt\\PracticeLessons\\Word";
                    if (!Directory.Exists(saveFileLocDirectory))
                    {
                        Directory.CreateDirectory(saveFileLocDirectory);
                    }
                    string saveFileLocCopy = saveFileLocDirectory + "\\" + fileName;

                    string message = CommonUtility.GetCharacterCountinLine(selectFileLoc);
                    if (!string.IsNullOrEmpty(message))
                    {
                        MessageBox.Show(message, @"Invalid character length", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (File.Exists(selectFileLoc))
                    {
                        //if exists replace or do nothing
                        if (File.Exists(saveFileLocCopy))
                        {
                            DialogResult dialogResult =
                                MessageBox.Show(@"Destination folder have this lesson, do you want to replace?",
                                    @"Replace",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dialogResult.Equals(DialogResult.Yes))
                            {

                                File.Delete(saveFileLocCopy);
                            }
                            else if (dialogResult.Equals(DialogResult.No))
                            {
                                return;
                            }
                        }
                        File.Copy(selectFileLoc, saveFileLocCopy);
                    }
                }
            }
            LoadAllLessons();
            textBox2.Focus();

            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Text File|*.txt";
            //sfd.FileName = "Password";
            //sfd.Title = "Save Text File";
            //if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string path = sfd.FileName;
            //    StreamWriter bw = new StreamWriter(File.Create(path));
            //    bw.Write("test alsjdfkasjdflk sdfjlkasdjflaksdf asdf skdlfjsdlkfs dfsadflksdaf ");
            //    bw.Dispose();
            //}
        }

        private void btnFontPlus_Click(object sender, EventArgs e)
        {
            string btnPlusFontVal = btnFontPlus.Text.Split('(')[1].Substring(0,
                btnFontPlus.Text.Split('(')[1].Length - 1);
            //string[] btnVal = btnPlus.Split('(');
            //string curVal =  btnVal[1];
            //  string fontVal = btnPlus.Substring(0, 2);
            currentLessonFontSize = int.Parse(btnPlusFontVal) + 1;
            if (currentLessonFontSize < 23)
            {
                _clsLessonCoach.displayNewLesson(LblFromCoachLessonList, currentLessonFontSize);
                btnFontPlus.Text = @"Lesson char font size increase +(" + currentLessonFontSize + ")";
                btnFontMinus.Text = @"Lesson char font size decrease -(" + currentLessonFontSize + ")";
            }
            else
            {
                MessageBox.Show(@"Font size cann't be grater than 22.", "font size", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            textBox2.Focus();
        }

        private void btnFontMinus_Click(object sender, EventArgs e)
        {
            string btnPlus = btnFontPlus.Text;
            string[] btnVal = btnPlus.Split('(');
            string curVal = btnVal[1];
            string fontVal = curVal.Substring(0, curVal.Length - 1);
            currentLessonFontSize = int.Parse(fontVal) - 1;
            if (currentLessonFontSize < 8)
            {
                MessageBox.Show(@"Font size cann't be less than 8.", "font size", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                _clsLessonCoach.displayNewLesson(LblFromCoachLessonList, currentLessonFontSize);
                btnFontPlus.Text = @"Lesson char font size increase +(" + currentLessonFontSize + @")";
                btnFontMinus.Text = @"Lesson char font size decrease -(" + currentLessonFontSize + @")";
            }
            textBox2.Focus();
        }

        //Timer pause button effect
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timer3.Enabled)
            {
                timer3.Stop();
            }
            else
            {
                timer3.Start();
            }

        }

        private void btnShiftRight_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void dgvLessonListHome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Focus();
        }

        //private void dgvLessonListHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgvLessonListHome.SelectedCells.Count > 0)
        //    {
        //        int selectedRowIndex = dgvLessonListHome.SelectedCells[0].RowIndex;
        //        DataGridViewRow selectedRows = dgvLessonListHome.Rows[selectedRowIndex];
        //        _dgvSelectedLessonForTyping = selectedRows.Cells[0].Value.ToString();
        //        _dgvSelectedLessonForTyping += ".txt";
        //        FormLoadDefaultData();
        //        //LessonDataLoad();
        //    }
        //}

        private void CorrectKeySound()
        {
            if (GlobalVarManager.EnableSound)
            {
                mdlAPI.Beep(1500, 30);  //500 is frequency and 12 is duration
            }
        }

        private void WrongKeySound()
        {
            if (GlobalVarManager.EnableSound)
            {
                mdlAPI.Beep(1200, 60);//1200 is frequency and 60 is duration
            }
        }
        private void frmTypinGuide_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            Application.Exit();
            main.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings setting = new frmSettings();
            setting.ShowDialog();
            LoadBasicSettings();
        }

        private void lbLesson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                //string indicee = lbLesson.SelectedItem.ToString();
            }
            if (e.KeyCode == Keys.Down)
            {
                //int indicee = lbLesson.SelectedIndex;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (lbLesson.SelectedItems.Count > 0)
                {
                    string item = lbLesson.Text;
                    _lbSelectedLessonForTyping = item.ToString();
                    _lbSelectedLessonForTyping += ".txt";
                    FormLoadDefaultData();
                }
                textBox2.Focus();
            }
        }

        private void lbLesson_DoubleClick(object sender, EventArgs e)
        {
            if (lbLesson.SelectedItems.Count > 0)
            {
                string item = lbLesson.Text;
                _lbSelectedLessonForTyping = item.ToString();
                _lbSelectedLessonForTyping += ".txt";
                FormLoadDefaultData();
            }
            textBox2.Focus();
        }
    }
}

