using System;
using System.Drawing;
using System.Windows.Forms;

namespace prjTypinGuide
{
    partial class frmTypinWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypinWord));
            this.lblTime = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typingLessonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLessonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handleCapsLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.typingProgressBar = new System.Windows.Forms.ProgressBar();
            this.grpBxKeybr = new System.Windows.Forms.GroupBox();
            this.btnRightwardArrow = new System.Windows.Forms.Button();
            this.btnNumEnter = new System.Windows.Forms.Button();
            this.btnNumPlus = new System.Windows.Forms.Button();
            this.btnNumMinus = new System.Windows.Forms.Button();
            this.btnNumDel = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNumZeroInsert = new System.Windows.Forms.Button();
            this.btnNumMultiply = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnDownWardArrow = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnUpwardArrow = new System.Windows.Forms.Button();
            this.btnNumDivide = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnLeftwardArrow = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnPageDown = new System.Windows.Forms.Button();
            this.btnPageUp = new System.Windows.Forms.Button();
            this.btnNumlock = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnPipeForwardSlash = new System.Windows.Forms.Button();
            this.btnSecondThirdClose = new System.Windows.Forms.Button();
            this.btnSecondThirdOpen = new System.Windows.Forms.Button();
            this.btnHypenUnderScore = new System.Windows.Forms.Button();
            this.btnPlusEquals = new System.Windows.Forms.Button();
            this.btnTildeAcute = new System.Windows.Forms.Button();
            this.btnSpaceBar = new System.Windows.Forms.Button();
            this.btnQuestionMarkBackSlash = new System.Windows.Forms.Button();
            this.btnGreaterThanFullStop = new System.Windows.Forms.Button();
            this.btnLessThanComma = new System.Windows.Forms.Button();
            this.btnQuotation = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.btnCtrlRight = new System.Windows.Forms.Button();
            this.btnAltRight = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnAltLeft = new System.Windows.Forms.Button();
            this.btnCtrlLeft = new System.Windows.Forms.Button();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.btnColonSemiColon = new System.Windows.Forms.Button();
            this.btnCapsLock = new System.Windows.Forms.Button();
            this.btnTab = new System.Windows.Forms.Button();
            this.btn6Caret = new System.Windows.Forms.Button();
            this.btn7And = new System.Windows.Forms.Button();
            this.btn8Star = new System.Windows.Forms.Button();
            this.btn9OpenParenthesis = new System.Windows.Forms.Button();
            this.btn0CloseParenthesis = new System.Windows.Forms.Button();
            this.btn5Percentage = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btn1Exclamation = new System.Windows.Forms.Button();
            this.btn2AtTheRate = new System.Windows.Forms.Button();
            this.btn3Hash = new System.Windows.Forms.Button();
            this.btn4Dollar = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.grpBxLessionList = new System.Windows.Forms.GroupBox();
            this.lbLesson = new System.Windows.Forms.ListBox();
            this.btnFontMinus = new System.Windows.Forms.Button();
            this.btnFontPlus = new System.Windows.Forms.Button();
            this.lblProgressBarPercentage = new System.Windows.Forms.Label();
            this.lblUpperTitleMsg = new System.Windows.Forms.Label();
            this.lblCharacterScoreMsg = new System.Windows.Forms.Label();
            this.lblWordScoreMsg = new System.Windows.Forms.Label();
            this.lblCharPerMin = new System.Windows.Forms.Label();
            this.lblWordPerMin = new System.Windows.Forms.Label();
            this.MP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBxKeybr.SuspendLayout();
            this.grpBxLessionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(51, 452);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(115, 27);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "lblTime";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(570, 450);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 29);
            this.textBox2.TabIndex = 0;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Image1
            // 
            this.Image1.Image = ((System.Drawing.Image)(resources.GetObject("Image1.Image")));
            this.Image1.Location = new System.Drawing.Point(1034, 456);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(30, 24);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image1.TabIndex = 5;
            this.Image1.TabStop = false;
            this.toolTip1.SetToolTip(this.Image1, "Open Music");
            this.Image1.Click += new System.EventHandler(this.Image1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.typingLessonsToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem.Image")));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.quitToolStripMenuItem.Text = "Home";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // typingLessonsToolStripMenuItem
            // 
            this.typingLessonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectLessonToolStripMenuItem,
            this.handleCapsLockToolStripMenuItem});
            this.typingLessonsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("typingLessonsToolStripMenuItem.Image")));
            this.typingLessonsToolStripMenuItem.Name = "typingLessonsToolStripMenuItem";
            this.typingLessonsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.typingLessonsToolStripMenuItem.Text = "Lesson Settings";
            // 
            // selectLessonToolStripMenuItem
            // 
            this.selectLessonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectLessonToolStripMenuItem.Image")));
            this.selectLessonToolStripMenuItem.Name = "selectLessonToolStripMenuItem";
            this.selectLessonToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.selectLessonToolStripMenuItem.Text = "Practice Lesson";
            this.selectLessonToolStripMenuItem.Click += new System.EventHandler(this.selectLessonToolStripMenuItem_Click);
            // 
            // handleCapsLockToolStripMenuItem
            // 
            this.handleCapsLockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("handleCapsLockToolStripMenuItem.Image")));
            this.handleCapsLockToolStripMenuItem.Name = "handleCapsLockToolStripMenuItem";
            this.handleCapsLockToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.handleCapsLockToolStripMenuItem.Text = "Upload Lesson";
            this.handleCapsLockToolStripMenuItem.Click += new System.EventHandler(this.handleCapsLockToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configurationToolStripMenuItem.Image")));
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 452);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Time Out The Stop Watch");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mp3";
            this.openFileDialog1.Title = "Select Media File";
            // 
            // typingProgressBar
            // 
            this.typingProgressBar.Location = new System.Drawing.Point(174, 456);
            this.typingProgressBar.Name = "typingProgressBar";
            this.typingProgressBar.Size = new System.Drawing.Size(252, 21);
            this.typingProgressBar.TabIndex = 8;
            // 
            // grpBxKeybr
            // 
            this.grpBxKeybr.BackColor = System.Drawing.Color.LightCyan;
            this.grpBxKeybr.Controls.Add(this.btnRightwardArrow);
            this.grpBxKeybr.Controls.Add(this.btnNumEnter);
            this.grpBxKeybr.Controls.Add(this.btnNumPlus);
            this.grpBxKeybr.Controls.Add(this.btnNumMinus);
            this.grpBxKeybr.Controls.Add(this.btnNumDel);
            this.grpBxKeybr.Controls.Add(this.btnNum3);
            this.grpBxKeybr.Controls.Add(this.btnNum6);
            this.grpBxKeybr.Controls.Add(this.btnNum9);
            this.grpBxKeybr.Controls.Add(this.btnNumZeroInsert);
            this.grpBxKeybr.Controls.Add(this.btnNumMultiply);
            this.grpBxKeybr.Controls.Add(this.btnNum2);
            this.grpBxKeybr.Controls.Add(this.btnDownWardArrow);
            this.grpBxKeybr.Controls.Add(this.btnNum5);
            this.grpBxKeybr.Controls.Add(this.btnNum8);
            this.grpBxKeybr.Controls.Add(this.btnUpwardArrow);
            this.grpBxKeybr.Controls.Add(this.btnNumDivide);
            this.grpBxKeybr.Controls.Add(this.btnNum1);
            this.grpBxKeybr.Controls.Add(this.btnLeftwardArrow);
            this.grpBxKeybr.Controls.Add(this.btnNum4);
            this.grpBxKeybr.Controls.Add(this.btnNum7);
            this.grpBxKeybr.Controls.Add(this.btnPageDown);
            this.grpBxKeybr.Controls.Add(this.btnPageUp);
            this.grpBxKeybr.Controls.Add(this.btnNumlock);
            this.grpBxKeybr.Controls.Add(this.btnEnd);
            this.grpBxKeybr.Controls.Add(this.btnDelete);
            this.grpBxKeybr.Controls.Add(this.btnHome);
            this.grpBxKeybr.Controls.Add(this.btnInsert);
            this.grpBxKeybr.Controls.Add(this.btnBackSpace);
            this.grpBxKeybr.Controls.Add(this.btnPipeForwardSlash);
            this.grpBxKeybr.Controls.Add(this.btnSecondThirdClose);
            this.grpBxKeybr.Controls.Add(this.btnSecondThirdOpen);
            this.grpBxKeybr.Controls.Add(this.btnHypenUnderScore);
            this.grpBxKeybr.Controls.Add(this.btnPlusEquals);
            this.grpBxKeybr.Controls.Add(this.btnTildeAcute);
            this.grpBxKeybr.Controls.Add(this.btnSpaceBar);
            this.grpBxKeybr.Controls.Add(this.btnQuestionMarkBackSlash);
            this.grpBxKeybr.Controls.Add(this.btnGreaterThanFullStop);
            this.grpBxKeybr.Controls.Add(this.btnLessThanComma);
            this.grpBxKeybr.Controls.Add(this.btnQuotation);
            this.grpBxKeybr.Controls.Add(this.btnShiftRight);
            this.grpBxKeybr.Controls.Add(this.btnCtrlRight);
            this.grpBxKeybr.Controls.Add(this.btnAltRight);
            this.grpBxKeybr.Controls.Add(this.btnEnter);
            this.grpBxKeybr.Controls.Add(this.btnAltLeft);
            this.grpBxKeybr.Controls.Add(this.btnCtrlLeft);
            this.grpBxKeybr.Controls.Add(this.btnShiftLeft);
            this.grpBxKeybr.Controls.Add(this.btnColonSemiColon);
            this.grpBxKeybr.Controls.Add(this.btnCapsLock);
            this.grpBxKeybr.Controls.Add(this.btnTab);
            this.grpBxKeybr.Controls.Add(this.btn6Caret);
            this.grpBxKeybr.Controls.Add(this.btn7And);
            this.grpBxKeybr.Controls.Add(this.btn8Star);
            this.grpBxKeybr.Controls.Add(this.btn9OpenParenthesis);
            this.grpBxKeybr.Controls.Add(this.btn0CloseParenthesis);
            this.grpBxKeybr.Controls.Add(this.btn5Percentage);
            this.grpBxKeybr.Controls.Add(this.btnZ);
            this.grpBxKeybr.Controls.Add(this.btn1Exclamation);
            this.grpBxKeybr.Controls.Add(this.btn2AtTheRate);
            this.grpBxKeybr.Controls.Add(this.btn3Hash);
            this.grpBxKeybr.Controls.Add(this.btn4Dollar);
            this.grpBxKeybr.Controls.Add(this.btnY);
            this.grpBxKeybr.Controls.Add(this.btnT);
            this.grpBxKeybr.Controls.Add(this.btnU);
            this.grpBxKeybr.Controls.Add(this.btnV);
            this.grpBxKeybr.Controls.Add(this.btnW);
            this.grpBxKeybr.Controls.Add(this.btnX);
            this.grpBxKeybr.Controls.Add(this.btnS);
            this.grpBxKeybr.Controls.Add(this.btnN);
            this.grpBxKeybr.Controls.Add(this.btnO);
            this.grpBxKeybr.Controls.Add(this.btnP);
            this.grpBxKeybr.Controls.Add(this.btnQ);
            this.grpBxKeybr.Controls.Add(this.btnR);
            this.grpBxKeybr.Controls.Add(this.btnM);
            this.grpBxKeybr.Controls.Add(this.btnH);
            this.grpBxKeybr.Controls.Add(this.btnI);
            this.grpBxKeybr.Controls.Add(this.btnJ);
            this.grpBxKeybr.Controls.Add(this.btnK);
            this.grpBxKeybr.Controls.Add(this.btnL);
            this.grpBxKeybr.Controls.Add(this.btnG);
            this.grpBxKeybr.Controls.Add(this.btnB);
            this.grpBxKeybr.Controls.Add(this.btnC);
            this.grpBxKeybr.Controls.Add(this.btnD);
            this.grpBxKeybr.Controls.Add(this.btnE);
            this.grpBxKeybr.Controls.Add(this.btnF);
            this.grpBxKeybr.Controls.Add(this.btnA);
            this.grpBxKeybr.Location = new System.Drawing.Point(4, 135);
            this.grpBxKeybr.Name = "grpBxKeybr";
            this.grpBxKeybr.Size = new System.Drawing.Size(896, 205);
            this.grpBxKeybr.TabIndex = 10;
            this.grpBxKeybr.TabStop = false;
            this.grpBxKeybr.Text = "Keyboard";
            // 
            // btnRightwardArrow
            // 
            this.btnRightwardArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(111)))));
            this.btnRightwardArrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRightwardArrow.Location = new System.Drawing.Point(655, 156);
            this.btnRightwardArrow.Name = "btnRightwardArrow";
            this.btnRightwardArrow.Size = new System.Drawing.Size(38, 36);
            this.btnRightwardArrow.TabIndex = 59;
            this.btnRightwardArrow.TabStop = false;
            this.btnRightwardArrow.Text = "→";
            this.btnRightwardArrow.UseVisualStyleBackColor = false;
            this.btnRightwardArrow.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNumEnter
            // 
            this.btnNumEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnNumEnter.Location = new System.Drawing.Point(842, 123);
            this.btnNumEnter.Name = "btnNumEnter";
            this.btnNumEnter.Size = new System.Drawing.Size(44, 69);
            this.btnNumEnter.TabIndex = 59;
            this.btnNumEnter.TabStop = false;
            this.btnNumEnter.Text = "Enter";
            this.btnNumEnter.UseVisualStyleBackColor = false;
            this.btnNumEnter.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNumPlus
            // 
            this.btnNumPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnNumPlus.Location = new System.Drawing.Point(842, 55);
            this.btnNumPlus.Name = "btnNumPlus";
            this.btnNumPlus.Size = new System.Drawing.Size(44, 70);
            this.btnNumPlus.TabIndex = 59;
            this.btnNumPlus.TabStop = false;
            this.btnNumPlus.Text = "+";
            this.btnNumPlus.UseVisualStyleBackColor = false;
            this.btnNumPlus.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNumMinus
            // 
            this.btnNumMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnNumMinus.Location = new System.Drawing.Point(842, 19);
            this.btnNumMinus.Name = "btnNumMinus";
            this.btnNumMinus.Size = new System.Drawing.Size(44, 36);
            this.btnNumMinus.TabIndex = 59;
            this.btnNumMinus.TabStop = false;
            this.btnNumMinus.Text = "-";
            this.btnNumMinus.UseVisualStyleBackColor = false;
            this.btnNumMinus.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNumDel
            // 
            this.btnNumDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(209)))));
            this.btnNumDel.Location = new System.Drawing.Point(800, 156);
            this.btnNumDel.Name = "btnNumDel";
            this.btnNumDel.Size = new System.Drawing.Size(44, 36);
            this.btnNumDel.TabIndex = 59;
            this.btnNumDel.TabStop = false;
            this.btnNumDel.Text = "Del";
            this.btnNumDel.UseVisualStyleBackColor = false;
            this.btnNumDel.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(209)))));
            this.btnNum3.Location = new System.Drawing.Point(800, 123);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(45, 36);
            this.btnNum3.TabIndex = 59;
            this.btnNum3.TabStop = false;
            this.btnNum3.Text = "3\r\nPg Up";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(209)))));
            this.btnNum6.Location = new System.Drawing.Point(800, 89);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(44, 36);
            this.btnNum6.TabIndex = 59;
            this.btnNum6.TabStop = false;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(209)))));
            this.btnNum9.Location = new System.Drawing.Point(800, 55);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(45, 36);
            this.btnNum9.TabIndex = 59;
            this.btnNum9.TabStop = false;
            this.btnNum9.Text = "9\r\nPg Dn";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNumZeroInsert
            // 
            this.btnNumZeroInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(197)))));
            this.btnNumZeroInsert.Location = new System.Drawing.Point(716, 156);
            this.btnNumZeroInsert.Name = "btnNumZeroInsert";
            this.btnNumZeroInsert.Size = new System.Drawing.Size(86, 36);
            this.btnNumZeroInsert.TabIndex = 59;
            this.btnNumZeroInsert.TabStop = false;
            this.btnNumZeroInsert.Text = "0\r\nInsert\r\n";
            this.btnNumZeroInsert.UseVisualStyleBackColor = false;
            this.btnNumZeroInsert.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNumMultiply
            // 
            this.btnNumMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(209)))));
            this.btnNumMultiply.Location = new System.Drawing.Point(800, 19);
            this.btnNumMultiply.Name = "btnNumMultiply";
            this.btnNumMultiply.Size = new System.Drawing.Size(44, 36);
            this.btnNumMultiply.TabIndex = 59;
            this.btnNumMultiply.TabStop = false;
            this.btnNumMultiply.Text = "X";
            this.btnNumMultiply.UseVisualStyleBackColor = false;
            this.btnNumMultiply.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.btnNum2.Location = new System.Drawing.Point(758, 123);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(44, 36);
            this.btnNum2.TabIndex = 59;
            this.btnNum2.TabStop = false;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnDownWardArrow
            // 
            this.btnDownWardArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(111)))));
            this.btnDownWardArrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDownWardArrow.Location = new System.Drawing.Point(623, 156);
            this.btnDownWardArrow.Name = "btnDownWardArrow";
            this.btnDownWardArrow.Size = new System.Drawing.Size(38, 36);
            this.btnDownWardArrow.TabIndex = 59;
            this.btnDownWardArrow.TabStop = false;
            this.btnDownWardArrow.Text = "↓";
            this.btnDownWardArrow.UseVisualStyleBackColor = false;
            this.btnDownWardArrow.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.btnNum5.Location = new System.Drawing.Point(758, 89);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(44, 36);
            this.btnNum5.TabIndex = 59;
            this.btnNum5.TabStop = false;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.btnNum8.Location = new System.Drawing.Point(758, 55);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(44, 36);
            this.btnNum8.TabIndex = 59;
            this.btnNum8.TabStop = false;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnUpwardArrow
            // 
            this.btnUpwardArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(111)))));
            this.btnUpwardArrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpwardArrow.Location = new System.Drawing.Point(623, 123);
            this.btnUpwardArrow.Name = "btnUpwardArrow";
            this.btnUpwardArrow.Size = new System.Drawing.Size(38, 36);
            this.btnUpwardArrow.TabIndex = 59;
            this.btnUpwardArrow.TabStop = false;
            this.btnUpwardArrow.Text = "↑";
            this.btnUpwardArrow.UseVisualStyleBackColor = false;
            this.btnUpwardArrow.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNumDivide
            // 
            this.btnNumDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(86)))), ((int)(((byte)(124)))));
            this.btnNumDivide.Location = new System.Drawing.Point(758, 19);
            this.btnNumDivide.Name = "btnNumDivide";
            this.btnNumDivide.Size = new System.Drawing.Size(44, 36);
            this.btnNumDivide.TabIndex = 59;
            this.btnNumDivide.TabStop = false;
            this.btnNumDivide.Text = "/";
            this.btnNumDivide.UseVisualStyleBackColor = false;
            this.btnNumDivide.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(197)))));
            this.btnNum1.Location = new System.Drawing.Point(716, 123);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(44, 36);
            this.btnNum1.TabIndex = 59;
            this.btnNum1.TabStop = false;
            this.btnNum1.Text = "1\r\nEnd\r\n";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnLeftwardArrow
            // 
            this.btnLeftwardArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(111)))));
            this.btnLeftwardArrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLeftwardArrow.Location = new System.Drawing.Point(589, 156);
            this.btnLeftwardArrow.Name = "btnLeftwardArrow";
            this.btnLeftwardArrow.Size = new System.Drawing.Size(38, 36);
            this.btnLeftwardArrow.TabIndex = 59;
            this.btnLeftwardArrow.TabStop = false;
            this.btnLeftwardArrow.Text = "←";
            this.btnLeftwardArrow.UseVisualStyleBackColor = false;
            this.btnLeftwardArrow.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(197)))));
            this.btnNum4.Location = new System.Drawing.Point(716, 89);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(44, 36);
            this.btnNum4.TabIndex = 59;
            this.btnNum4.TabStop = false;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(197)))));
            this.btnNum7.Location = new System.Drawing.Point(716, 55);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(44, 36);
            this.btnNum7.TabIndex = 59;
            this.btnNum7.TabStop = false;
            this.btnNum7.Text = "7\r\nHome";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnPageDown
            // 
            this.btnPageDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(111)))));
            this.btnPageDown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPageDown.Location = new System.Drawing.Point(655, 55);
            this.btnPageDown.Name = "btnPageDown";
            this.btnPageDown.Size = new System.Drawing.Size(46, 36);
            this.btnPageDown.TabIndex = 59;
            this.btnPageDown.TabStop = false;
            this.btnPageDown.Text = "Page Down";
            this.btnPageDown.UseVisualStyleBackColor = false;
            this.btnPageDown.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnPageUp
            // 
            this.btnPageUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(111)))));
            this.btnPageUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPageUp.Location = new System.Drawing.Point(655, 19);
            this.btnPageUp.Name = "btnPageUp";
            this.btnPageUp.Size = new System.Drawing.Size(46, 36);
            this.btnPageUp.TabIndex = 59;
            this.btnPageUp.TabStop = false;
            this.btnPageUp.Text = "Page Up";
            this.btnPageUp.UseVisualStyleBackColor = false;
            this.btnPageUp.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnNumlock
            // 
            this.btnNumlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(197)))));
            this.btnNumlock.Location = new System.Drawing.Point(716, 19);
            this.btnNumlock.Name = "btnNumlock";
            this.btnNumlock.Size = new System.Drawing.Size(44, 36);
            this.btnNumlock.TabIndex = 59;
            this.btnNumlock.TabStop = false;
            this.btnNumlock.Text = "Num Lock";
            this.btnNumlock.UseVisualStyleBackColor = false;
            this.btnNumlock.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(111)))));
            this.btnEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnd.Location = new System.Drawing.Point(619, 55);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(46, 36);
            this.btnEnd.TabIndex = 59;
            this.btnEnd.TabStop = false;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(111)))));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(574, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(46, 36);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(111)))));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Location = new System.Drawing.Point(614, 19);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(46, 36);
            this.btnHome.TabIndex = 59;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(111)))));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.Location = new System.Drawing.Point(573, 19);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(46, 36);
            this.btnInsert.TabIndex = 59;
            this.btnInsert.TabStop = false;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(173)))), ((int)(((byte)(91)))));
            this.btnBackSpace.Location = new System.Drawing.Point(499, 19);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(72, 39);
            this.btnBackSpace.TabIndex = 58;
            this.btnBackSpace.TabStop = false;
            this.btnBackSpace.Text = "Backspace";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnPipeForwardSlash
            // 
            this.btnPipeForwardSlash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(173)))), ((int)(((byte)(91)))));
            this.btnPipeForwardSlash.Location = new System.Drawing.Point(507, 55);
            this.btnPipeForwardSlash.Name = "btnPipeForwardSlash";
            this.btnPipeForwardSlash.Size = new System.Drawing.Size(38, 36);
            this.btnPipeForwardSlash.TabIndex = 56;
            this.btnPipeForwardSlash.TabStop = false;
            this.btnPipeForwardSlash.Text = "|\r\n\\";
            this.btnPipeForwardSlash.UseVisualStyleBackColor = false;
            this.btnPipeForwardSlash.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnSecondThirdClose
            // 
            this.btnSecondThirdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnSecondThirdClose.Location = new System.Drawing.Point(472, 55);
            this.btnSecondThirdClose.Name = "btnSecondThirdClose";
            this.btnSecondThirdClose.Size = new System.Drawing.Size(38, 36);
            this.btnSecondThirdClose.TabIndex = 56;
            this.btnSecondThirdClose.TabStop = false;
            this.btnSecondThirdClose.Text = "}\r\n]";
            this.btnSecondThirdClose.UseVisualStyleBackColor = false;
            this.btnSecondThirdClose.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnSecondThirdOpen
            // 
            this.btnSecondThirdOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnSecondThirdOpen.Location = new System.Drawing.Point(438, 55);
            this.btnSecondThirdOpen.Name = "btnSecondThirdOpen";
            this.btnSecondThirdOpen.Size = new System.Drawing.Size(38, 36);
            this.btnSecondThirdOpen.TabIndex = 56;
            this.btnSecondThirdOpen.TabStop = false;
            this.btnSecondThirdOpen.Text = "{\r\n[";
            this.btnSecondThirdOpen.UseVisualStyleBackColor = false;
            this.btnSecondThirdOpen.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnHypenUnderScore
            // 
            this.btnHypenUnderScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnHypenUnderScore.Location = new System.Drawing.Point(422, 19);
            this.btnHypenUnderScore.Name = "btnHypenUnderScore";
            this.btnHypenUnderScore.Size = new System.Drawing.Size(42, 38);
            this.btnHypenUnderScore.TabIndex = 55;
            this.btnHypenUnderScore.TabStop = false;
            this.btnHypenUnderScore.Text = "_\r\n-";
            this.btnHypenUnderScore.UseVisualStyleBackColor = false;
            this.btnHypenUnderScore.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnPlusEquals
            // 
            this.btnPlusEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnPlusEquals.Location = new System.Drawing.Point(460, 19);
            this.btnPlusEquals.Name = "btnPlusEquals";
            this.btnPlusEquals.Size = new System.Drawing.Size(42, 38);
            this.btnPlusEquals.TabIndex = 54;
            this.btnPlusEquals.TabStop = false;
            this.btnPlusEquals.Text = "+\r\n=";
            this.btnPlusEquals.UseVisualStyleBackColor = false;
            this.btnPlusEquals.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnTildeAcute
            // 
            this.btnTildeAcute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(177)))), ((int)(((byte)(87)))));
            this.btnTildeAcute.Location = new System.Drawing.Point(8, 19);
            this.btnTildeAcute.Name = "btnTildeAcute";
            this.btnTildeAcute.Size = new System.Drawing.Size(40, 39);
            this.btnTildeAcute.TabIndex = 53;
            this.btnTildeAcute.TabStop = false;
            this.btnTildeAcute.Text = "~\r\n`\r\n";
            this.btnTildeAcute.UseVisualStyleBackColor = false;
            this.btnTildeAcute.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnSpaceBar
            // 
            this.btnSpaceBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(177)))), ((int)(((byte)(87)))));
            this.btnSpaceBar.Location = new System.Drawing.Point(121, 156);
            this.btnSpaceBar.Name = "btnSpaceBar";
            this.btnSpaceBar.Size = new System.Drawing.Size(332, 36);
            this.btnSpaceBar.TabIndex = 52;
            this.btnSpaceBar.TabStop = false;
            this.btnSpaceBar.UseVisualStyleBackColor = false;
            this.btnSpaceBar.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnQuestionMarkBackSlash
            // 
            this.btnQuestionMarkBackSlash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnQuestionMarkBackSlash.Location = new System.Drawing.Point(426, 123);
            this.btnQuestionMarkBackSlash.Name = "btnQuestionMarkBackSlash";
            this.btnQuestionMarkBackSlash.Size = new System.Drawing.Size(38, 36);
            this.btnQuestionMarkBackSlash.TabIndex = 51;
            this.btnQuestionMarkBackSlash.TabStop = false;
            this.btnQuestionMarkBackSlash.Text = "?\r\n /";
            this.btnQuestionMarkBackSlash.UseVisualStyleBackColor = false;
            this.btnQuestionMarkBackSlash.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnGreaterThanFullStop
            // 
            this.btnGreaterThanFullStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(161)))), ((int)(((byte)(210)))));
            this.btnGreaterThanFullStop.Location = new System.Drawing.Point(390, 123);
            this.btnGreaterThanFullStop.Name = "btnGreaterThanFullStop";
            this.btnGreaterThanFullStop.Size = new System.Drawing.Size(38, 36);
            this.btnGreaterThanFullStop.TabIndex = 50;
            this.btnGreaterThanFullStop.TabStop = false;
            this.btnGreaterThanFullStop.Text = ">\r\n .\r\n";
            this.btnGreaterThanFullStop.UseVisualStyleBackColor = false;
            this.btnGreaterThanFullStop.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnLessThanComma
            // 
            this.btnLessThanComma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.btnLessThanComma.Location = new System.Drawing.Point(356, 123);
            this.btnLessThanComma.Name = "btnLessThanComma";
            this.btnLessThanComma.Size = new System.Drawing.Size(38, 36);
            this.btnLessThanComma.TabIndex = 49;
            this.btnLessThanComma.TabStop = false;
            this.btnLessThanComma.Text = "<\r\n ,";
            this.btnLessThanComma.UseVisualStyleBackColor = false;
            this.btnLessThanComma.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnQuotation
            // 
            this.btnQuotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnQuotation.Location = new System.Drawing.Point(433, 89);
            this.btnQuotation.Name = "btnQuotation";
            this.btnQuotation.Size = new System.Drawing.Size(38, 36);
            this.btnQuotation.TabIndex = 48;
            this.btnQuotation.TabStop = false;
            this.btnQuotation.UseVisualStyleBackColor = false;
            this.btnQuotation.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(173)))), ((int)(((byte)(91)))));
            this.btnShiftRight.Location = new System.Drawing.Point(459, 123);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(108, 36);
            this.btnShiftRight.TabIndex = 47;
            this.btnShiftRight.TabStop = false;
            this.btnShiftRight.Text = "Shift";
            this.btnShiftRight.UseVisualStyleBackColor = false;
            this.btnShiftRight.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnCtrlRight
            // 
            this.btnCtrlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCtrlRight.Location = new System.Drawing.Point(510, 156);
            this.btnCtrlRight.Name = "btnCtrlRight";
            this.btnCtrlRight.Size = new System.Drawing.Size(56, 36);
            this.btnCtrlRight.TabIndex = 47;
            this.btnCtrlRight.TabStop = false;
            this.btnCtrlRight.Text = "Ctrl";
            this.btnCtrlRight.UseVisualStyleBackColor = false;
            this.btnCtrlRight.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnAltRight
            // 
            this.btnAltRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAltRight.Location = new System.Drawing.Point(445, 156);
            this.btnAltRight.Name = "btnAltRight";
            this.btnAltRight.Size = new System.Drawing.Size(67, 36);
            this.btnAltRight.TabIndex = 47;
            this.btnAltRight.TabStop = false;
            this.btnAltRight.Text = "Alt";
            this.btnAltRight.UseVisualStyleBackColor = false;
            this.btnAltRight.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(173)))), ((int)(((byte)(91)))));
            this.btnEnter.Location = new System.Drawing.Point(468, 89);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(99, 36);
            this.btnEnter.TabIndex = 47;
            this.btnEnter.TabStop = false;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnAltLeft
            // 
            this.btnAltLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAltLeft.Location = new System.Drawing.Point(69, 156);
            this.btnAltLeft.Name = "btnAltLeft";
            this.btnAltLeft.Size = new System.Drawing.Size(60, 36);
            this.btnAltLeft.TabIndex = 47;
            this.btnAltLeft.TabStop = false;
            this.btnAltLeft.Text = "Alt";
            this.btnAltLeft.UseVisualStyleBackColor = false;
            this.btnAltLeft.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnCtrlLeft
            // 
            this.btnCtrlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCtrlLeft.Location = new System.Drawing.Point(9, 156);
            this.btnCtrlLeft.Name = "btnCtrlLeft";
            this.btnCtrlLeft.Size = new System.Drawing.Size(63, 36);
            this.btnCtrlLeft.TabIndex = 47;
            this.btnCtrlLeft.TabStop = false;
            this.btnCtrlLeft.Text = "Ctrl";
            this.btnCtrlLeft.UseVisualStyleBackColor = false;
            this.btnCtrlLeft.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(177)))), ((int)(((byte)(87)))));
            this.btnShiftLeft.Location = new System.Drawing.Point(9, 123);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(99, 36);
            this.btnShiftLeft.TabIndex = 46;
            this.btnShiftLeft.TabStop = false;
            this.btnShiftLeft.Text = "Shift";
            this.btnShiftLeft.UseVisualStyleBackColor = false;
            this.btnShiftLeft.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnColonSemiColon
            // 
            this.btnColonSemiColon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnColonSemiColon.Location = new System.Drawing.Point(400, 89);
            this.btnColonSemiColon.Name = "btnColonSemiColon";
            this.btnColonSemiColon.Size = new System.Drawing.Size(38, 36);
            this.btnColonSemiColon.TabIndex = 45;
            this.btnColonSemiColon.TabStop = false;
            this.btnColonSemiColon.UseVisualStyleBackColor = false;
            this.btnColonSemiColon.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnCapsLock
            // 
            this.btnCapsLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(177)))), ((int)(((byte)(87)))));
            this.btnCapsLock.Location = new System.Drawing.Point(9, 89);
            this.btnCapsLock.Name = "btnCapsLock";
            this.btnCapsLock.Size = new System.Drawing.Size(79, 36);
            this.btnCapsLock.TabIndex = 44;
            this.btnCapsLock.TabStop = false;
            this.btnCapsLock.Text = "Caps Lock";
            this.btnCapsLock.UseVisualStyleBackColor = false;
            this.btnCapsLock.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnTab
            // 
            this.btnTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(177)))), ((int)(((byte)(87)))));
            this.btnTab.Location = new System.Drawing.Point(9, 55);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(77, 36);
            this.btnTab.TabIndex = 43;
            this.btnTab.TabStop = false;
            this.btnTab.Text = "Tab";
            this.btnTab.UseVisualStyleBackColor = false;
            this.btnTab.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btn6Caret
            // 
            this.btn6Caret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btn6Caret.Location = new System.Drawing.Point(229, 19);
            this.btn6Caret.Name = "btn6Caret";
            this.btn6Caret.Size = new System.Drawing.Size(42, 38);
            this.btn6Caret.TabIndex = 40;
            this.btn6Caret.TabStop = false;
            this.btn6Caret.Text = "^\r\n6";
            this.btn6Caret.UseVisualStyleBackColor = false;
            this.btn6Caret.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btn7And
            // 
            this.btn7And.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(198)))));
            this.btn7And.Location = new System.Drawing.Point(267, 19);
            this.btn7And.Name = "btn7And";
            this.btn7And.Size = new System.Drawing.Size(42, 38);
            this.btn7And.TabIndex = 39;
            this.btn7And.TabStop = false;
            this.btn7And.Text = "&&\r\n7";
            this.btn7And.UseVisualStyleBackColor = false;
            this.btn7And.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btn8Star
            // 
            this.btn8Star.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.btn8Star.Location = new System.Drawing.Point(305, 19);
            this.btn8Star.Name = "btn8Star";
            this.btn8Star.Size = new System.Drawing.Size(42, 38);
            this.btn8Star.TabIndex = 38;
            this.btn8Star.TabStop = false;
            this.btn8Star.Text = "*\r\n8";
            this.btn8Star.UseVisualStyleBackColor = false;
            this.btn8Star.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btn9OpenParenthesis
            // 
            this.btn9OpenParenthesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(161)))), ((int)(((byte)(210)))));
            this.btn9OpenParenthesis.Location = new System.Drawing.Point(343, 19);
            this.btn9OpenParenthesis.Name = "btn9OpenParenthesis";
            this.btn9OpenParenthesis.Size = new System.Drawing.Size(42, 38);
            this.btn9OpenParenthesis.TabIndex = 37;
            this.btn9OpenParenthesis.TabStop = false;
            this.btn9OpenParenthesis.Text = "(\r\n9";
            this.btn9OpenParenthesis.UseVisualStyleBackColor = false;
            this.btn9OpenParenthesis.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btn0CloseParenthesis
            // 
            this.btn0CloseParenthesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btn0CloseParenthesis.Location = new System.Drawing.Point(381, 19);
            this.btn0CloseParenthesis.Name = "btn0CloseParenthesis";
            this.btn0CloseParenthesis.Size = new System.Drawing.Size(42, 38);
            this.btn0CloseParenthesis.TabIndex = 36;
            this.btn0CloseParenthesis.TabStop = false;
            this.btn0CloseParenthesis.Text = ")\r\n0";
            this.btn0CloseParenthesis.UseVisualStyleBackColor = false;
            this.btn0CloseParenthesis.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btn5Percentage
            // 
            this.btn5Percentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btn5Percentage.Location = new System.Drawing.Point(192, 19);
            this.btn5Percentage.Name = "btn5Percentage";
            this.btn5Percentage.Size = new System.Drawing.Size(42, 38);
            this.btn5Percentage.TabIndex = 35;
            this.btn5Percentage.TabStop = false;
            this.btn5Percentage.Text = "%\r\n5";
            this.btn5Percentage.UseVisualStyleBackColor = false;
            this.btn5Percentage.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(68)))), ((int)(((byte)(131)))));
            this.btnZ.Location = new System.Drawing.Point(106, 123);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(38, 36);
            this.btnZ.TabIndex = 34;
            this.btnZ.TabStop = false;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = false;
            this.btnZ.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btn1Exclamation
            // 
            this.btn1Exclamation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(68)))), ((int)(((byte)(131)))));
            this.btn1Exclamation.Location = new System.Drawing.Point(44, 19);
            this.btn1Exclamation.Name = "btn1Exclamation";
            this.btn1Exclamation.Size = new System.Drawing.Size(42, 38);
            this.btn1Exclamation.TabIndex = 33;
            this.btn1Exclamation.TabStop = false;
            this.btn1Exclamation.Text = "!\r\n1";
            this.btn1Exclamation.UseVisualStyleBackColor = false;
            this.btn1Exclamation.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btn2AtTheRate
            // 
            this.btn2AtTheRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(68)))), ((int)(((byte)(131)))));
            this.btn2AtTheRate.Location = new System.Drawing.Point(81, 19);
            this.btn2AtTheRate.Name = "btn2AtTheRate";
            this.btn2AtTheRate.Size = new System.Drawing.Size(42, 38);
            this.btn2AtTheRate.TabIndex = 32;
            this.btn2AtTheRate.TabStop = false;
            this.btn2AtTheRate.Text = "@\r\n2";
            this.btn2AtTheRate.UseVisualStyleBackColor = false;
            this.btn2AtTheRate.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btn3Hash
            // 
            this.btn3Hash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(192)))), ((int)(((byte)(237)))));
            this.btn3Hash.Location = new System.Drawing.Point(118, 19);
            this.btn3Hash.Name = "btn3Hash";
            this.btn3Hash.Size = new System.Drawing.Size(42, 38);
            this.btn3Hash.TabIndex = 31;
            this.btn3Hash.TabStop = false;
            this.btn3Hash.Text = "#\r\n3";
            this.btn3Hash.UseVisualStyleBackColor = false;
            this.btn3Hash.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btn4Dollar
            // 
            this.btn4Dollar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(76)))), ((int)(((byte)(154)))));
            this.btn4Dollar.Location = new System.Drawing.Point(155, 19);
            this.btn4Dollar.Name = "btn4Dollar";
            this.btn4Dollar.Size = new System.Drawing.Size(42, 38);
            this.btn4Dollar.TabIndex = 30;
            this.btn4Dollar.TabStop = false;
            this.btn4Dollar.Text = "$\r\n4";
            this.btn4Dollar.UseVisualStyleBackColor = false;
            this.btn4Dollar.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(198)))));
            this.btnY.Location = new System.Drawing.Point(264, 55);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(38, 36);
            this.btnY.TabIndex = 29;
            this.btnY.TabStop = false;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnT.Location = new System.Drawing.Point(228, 55);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(38, 36);
            this.btnT.TabIndex = 28;
            this.btnT.TabStop = false;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(198)))));
            this.btnU.Location = new System.Drawing.Point(300, 55);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(38, 36);
            this.btnU.TabIndex = 27;
            this.btnU.TabStop = false;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnV.Location = new System.Drawing.Point(214, 123);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(38, 36);
            this.btnV.TabIndex = 26;
            this.btnV.TabStop = false;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(192)))), ((int)(((byte)(237)))));
            this.btnW.Location = new System.Drawing.Point(121, 55);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(38, 36);
            this.btnW.TabIndex = 25;
            this.btnW.TabStop = false;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = false;
            this.btnW.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(192)))), ((int)(((byte)(237)))));
            this.btnX.Location = new System.Drawing.Point(142, 123);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(38, 36);
            this.btnX.TabIndex = 24;
            this.btnX.TabStop = false;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(192)))), ((int)(((byte)(237)))));
            this.btnS.Location = new System.Drawing.Point(121, 89);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(38, 36);
            this.btnS.TabIndex = 23;
            this.btnS.TabStop = false;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(198)))));
            this.btnN.Location = new System.Drawing.Point(286, 123);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(38, 36);
            this.btnN.TabIndex = 22;
            this.btnN.TabStop = false;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(161)))), ((int)(((byte)(210)))));
            this.btnO.Location = new System.Drawing.Point(368, 55);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(38, 36);
            this.btnO.TabIndex = 21;
            this.btnO.TabStop = false;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(67)))));
            this.btnP.Location = new System.Drawing.Point(401, 55);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(38, 36);
            this.btnP.TabIndex = 20;
            this.btnP.TabStop = false;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(68)))), ((int)(((byte)(131)))));
            this.btnQ.Location = new System.Drawing.Point(85, 55);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(38, 36);
            this.btnQ.TabIndex = 19;
            this.btnQ.TabStop = false;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = false;
            this.btnQ.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnR.Location = new System.Drawing.Point(192, 55);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(38, 36);
            this.btnR.TabIndex = 18;
            this.btnR.TabStop = false;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(198)))));
            this.btnM.Location = new System.Drawing.Point(320, 123);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(38, 36);
            this.btnM.TabIndex = 17;
            this.btnM.TabStop = false;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(198)))));
            this.btnH.Location = new System.Drawing.Point(263, 89);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(38, 36);
            this.btnH.TabIndex = 16;
            this.btnH.TabStop = false;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.btnI.Location = new System.Drawing.Point(332, 55);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(38, 36);
            this.btnI.TabIndex = 15;
            this.btnI.TabStop = false;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(94)))), ((int)(((byte)(198)))));
            this.btnJ.Location = new System.Drawing.Point(296, 89);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(38, 36);
            this.btnJ.TabIndex = 14;
            this.btnJ.TabStop = false;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = false;
            this.btnJ.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.btnK.Location = new System.Drawing.Point(332, 89);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(38, 36);
            this.btnK.TabIndex = 13;
            this.btnK.TabStop = false;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(161)))), ((int)(((byte)(210)))));
            this.btnL.Location = new System.Drawing.Point(364, 89);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(38, 36);
            this.btnL.TabIndex = 12;
            this.btnL.TabStop = false;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnG.Location = new System.Drawing.Point(229, 89);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(38, 36);
            this.btnG.TabIndex = 11;
            this.btnG.TabStop = false;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnB.Location = new System.Drawing.Point(250, 123);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(38, 36);
            this.btnB.TabIndex = 10;
            this.btnB.TabStop = false;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(76)))), ((int)(((byte)(154)))));
            this.btnC.Location = new System.Drawing.Point(178, 123);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(38, 36);
            this.btnC.TabIndex = 9;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(76)))), ((int)(((byte)(154)))));
            this.btnD.Location = new System.Drawing.Point(157, 89);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(38, 36);
            this.btnD.TabIndex = 8;
            this.btnD.TabStop = false;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(76)))), ((int)(((byte)(154)))));
            this.btnE.Location = new System.Drawing.Point(156, 55);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(38, 36);
            this.btnE.TabIndex = 7;
            this.btnE.TabStop = false;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnF.Location = new System.Drawing.Point(193, 89);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(38, 36);
            this.btnF.TabIndex = 6;
            this.btnF.TabStop = false;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(68)))), ((int)(((byte)(131)))));
            this.btnA.Location = new System.Drawing.Point(86, 89);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(38, 36);
            this.btnA.TabIndex = 0;
            this.btnA.TabStop = false;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // grpBxLessionList
            // 
            this.grpBxLessionList.BackColor = System.Drawing.Color.LightCyan;
            this.grpBxLessionList.Controls.Add(this.lbLesson);
            this.grpBxLessionList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBxLessionList.Location = new System.Drawing.Point(910, 134);
            this.grpBxLessionList.Name = "grpBxLessionList";
            this.grpBxLessionList.Size = new System.Drawing.Size(148, 206);
            this.grpBxLessionList.TabIndex = 11;
            this.grpBxLessionList.TabStop = false;
            this.grpBxLessionList.Text = "Lessons";
            // 
            // lbLesson
            // 
            this.lbLesson.FormattingEnabled = true;
            this.lbLesson.Location = new System.Drawing.Point(0, 20);
            this.lbLesson.Name = "lbLesson";
            this.lbLesson.Size = new System.Drawing.Size(148, 186);
            this.lbLesson.TabIndex = 21;
            this.lbLesson.DoubleClick += new System.EventHandler(this.lbLesson_DoubleClick);
            this.lbLesson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbLesson_KeyDown);
            // 
            // btnFontMinus
            // 
            this.btnFontMinus.BackColor = System.Drawing.Color.Brown;
            this.btnFontMinus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFontMinus.Location = new System.Drawing.Point(706, 446);
            this.btnFontMinus.Name = "btnFontMinus";
            this.btnFontMinus.Size = new System.Drawing.Size(105, 35);
            this.btnFontMinus.TabIndex = 13;
            this.btnFontMinus.TabStop = false;
            this.btnFontMinus.Text = "Lesson char font size decrease -(14)";
            this.btnFontMinus.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFontMinus.UseVisualStyleBackColor = false;
            this.btnFontMinus.Click += new System.EventHandler(this.btnFontMinus_Click);
            // 
            // btnFontPlus
            // 
            this.btnFontPlus.BackColor = System.Drawing.Color.Brown;
            this.btnFontPlus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFontPlus.Location = new System.Drawing.Point(599, 446);
            this.btnFontPlus.Name = "btnFontPlus";
            this.btnFontPlus.Size = new System.Drawing.Size(103, 35);
            this.btnFontPlus.TabIndex = 13;
            this.btnFontPlus.TabStop = false;
            this.btnFontPlus.Text = "Lesson char font size increase +(14)";
            this.btnFontPlus.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFontPlus.UseVisualStyleBackColor = false;
            this.btnFontPlus.Click += new System.EventHandler(this.btnFontPlus_Click);
            // 
            // lblProgressBarPercentage
            // 
            this.lblProgressBarPercentage.AutoSize = true;
            this.lblProgressBarPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBarPercentage.Location = new System.Drawing.Point(430, 457);
            this.lblProgressBarPercentage.Name = "lblProgressBarPercentage";
            this.lblProgressBarPercentage.Size = new System.Drawing.Size(80, 20);
            this.lblProgressBarPercentage.TabIndex = 12;
            this.lblProgressBarPercentage.Text = "Progress";
            // 
            // lblUpperTitleMsg
            // 
            this.lblUpperTitleMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(143)))));
            this.lblUpperTitleMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpperTitleMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lblUpperTitleMsg.Location = new System.Drawing.Point(3, 27);
            this.lblUpperTitleMsg.Name = "lblUpperTitleMsg";
            this.lblUpperTitleMsg.Size = new System.Drawing.Size(1065, 20);
            this.lblUpperTitleMsg.TabIndex = 14;
            this.lblUpperTitleMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharacterScoreMsg
            // 
            this.lblCharacterScoreMsg.AutoSize = true;
            this.lblCharacterScoreMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblCharacterScoreMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCharacterScoreMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.lblCharacterScoreMsg.Location = new System.Drawing.Point(6, 347);
            this.lblCharacterScoreMsg.Name = "lblCharacterScoreMsg";
            this.lblCharacterScoreMsg.Size = new System.Drawing.Size(0, 20);
            this.lblCharacterScoreMsg.TabIndex = 15;
            this.lblCharacterScoreMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWordScoreMsg
            // 
            this.lblWordScoreMsg.AutoSize = true;
            this.lblWordScoreMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblWordScoreMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblWordScoreMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.lblWordScoreMsg.Location = new System.Drawing.Point(6, 373);
            this.lblWordScoreMsg.Name = "lblWordScoreMsg";
            this.lblWordScoreMsg.Size = new System.Drawing.Size(0, 20);
            this.lblWordScoreMsg.TabIndex = 16;
            this.lblWordScoreMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharPerMin
            // 
            this.lblCharPerMin.AutoSize = true;
            this.lblCharPerMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblCharPerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCharPerMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.lblCharPerMin.Location = new System.Drawing.Point(6, 399);
            this.lblCharPerMin.Name = "lblCharPerMin";
            this.lblCharPerMin.Size = new System.Drawing.Size(0, 20);
            this.lblCharPerMin.TabIndex = 17;
            this.lblCharPerMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWordPerMin
            // 
            this.lblWordPerMin.AutoSize = true;
            this.lblWordPerMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblWordPerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblWordPerMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.lblWordPerMin.Location = new System.Drawing.Point(6, 425);
            this.lblWordPerMin.Name = "lblWordPerMin";
            this.lblWordPerMin.Size = new System.Drawing.Size(0, 20);
            this.lblWordPerMin.TabIndex = 18;
            this.lblWordPerMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MP
            // 
            this.MP.Enabled = true;
            this.MP.Location = new System.Drawing.Point(817, 442);
            this.MP.Name = "MP";
            this.MP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MP.OcxState")));
            this.MP.Size = new System.Drawing.Size(250, 42);
            this.MP.TabIndex = 4;
            this.MP.TabStop = false;
            this.MP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MP_PlayStateChange);
            this.MP.StatusChange += new System.EventHandler(this.MP_StatusChange);
            this.MP.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.MP_PositionChange);
            this.MP.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.MP_KeyDownEvent);
            this.MP.Enter += new System.EventHandler(this.MP_Enter);
            // 
            // frmTypinWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1071, 488);
            this.Controls.Add(this.lblWordPerMin);
            this.Controls.Add(this.lblCharPerMin);
            this.Controls.Add(this.lblWordScoreMsg);
            this.Controls.Add(this.lblCharacterScoreMsg);
            this.Controls.Add(this.lblUpperTitleMsg);
            this.Controls.Add(this.lblProgressBarPercentage);
            this.Controls.Add(this.btnFontPlus);
            this.Controls.Add(this.btnFontMinus);
            this.Controls.Add(this.grpBxLessionList);
            this.Controls.Add(this.grpBxKeybr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.typingProgressBar);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.MP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTypinWord";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Guide";
            this.Activated += new System.EventHandler(this.frmTypinGuide_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTypinGuide_FormClosing);
            this.Load += new System.EventHandler(this.frmTypinGuide_Load);
            this.Click += new System.EventHandler(this.frmTypinGuide_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBxKeybr.ResumeLayout(false);
            this.grpBxLessionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private AxWMPLib.AxWindowsMediaPlayer MP;
        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar typingProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBxKeybr;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btn6Caret;
        private System.Windows.Forms.Button btn7And;
        private System.Windows.Forms.Button btn8Star;
        private System.Windows.Forms.Button btn9OpenParenthesis;
        private System.Windows.Forms.Button btn0CloseParenthesis;
        private System.Windows.Forms.Button btn5Percentage;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btn1Exclamation;
        private System.Windows.Forms.Button btn3Hash;
        private System.Windows.Forms.Button btn4Dollar;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Button btnCapsLock;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.Button btnColonSemiColon;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Button btnCtrlRight;
        private System.Windows.Forms.Button btnAltLeft;
        private System.Windows.Forms.Button btnCtrlLeft;
        private System.Windows.Forms.Button btnAltRight;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnQuotation;
        private System.Windows.Forms.Button btnLessThanComma;
        private System.Windows.Forms.Button btnQuestionMarkBackSlash;
        private System.Windows.Forms.Button btnGreaterThanFullStop;
        private System.Windows.Forms.Button btnTildeAcute;
        private System.Windows.Forms.Button btnSpaceBar;
        private System.Windows.Forms.Button btnHypenUnderScore;
        private System.Windows.Forms.Button btnPlusEquals;
        private System.Windows.Forms.Button btnSecondThirdClose;
        private System.Windows.Forms.Button btnSecondThirdOpen;
        private System.Windows.Forms.Button btnPipeForwardSlash;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnRightwardArrow;
        private System.Windows.Forms.Button btnNumEnter;
        private System.Windows.Forms.Button btnNumPlus;
        private System.Windows.Forms.Button btnNumMinus;
        private System.Windows.Forms.Button btnNumDel;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNumZeroInsert;
        private System.Windows.Forms.Button btnNumMultiply;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnDownWardArrow;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnUpwardArrow;
        private System.Windows.Forms.Button btnNumDivide;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnLeftwardArrow;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnPageUp;
        private System.Windows.Forms.Button btnNumlock;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnPageDown;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnDelete;
        private ToolStripMenuItem typingLessonsToolStripMenuItem;
        private ToolStripMenuItem selectLessonToolStripMenuItem;
        private ToolStripMenuItem handleCapsLockToolStripMenuItem;
        private GroupBox grpBxLessionList;
        private Button btnFontMinus;
        private Button btnFontPlus;
        private Label lblProgressBarPercentage;
        private Label lblUpperTitleMsg;
        private Label lblCharacterScoreMsg;
        private Label lblWordScoreMsg;
        private Label lblCharPerMin;
        private Label lblWordPerMin;
        private ToolStripMenuItem configurationToolStripMenuItem;
        private Button btn2AtTheRate;
        private ListBox lbLesson;
    }
}

