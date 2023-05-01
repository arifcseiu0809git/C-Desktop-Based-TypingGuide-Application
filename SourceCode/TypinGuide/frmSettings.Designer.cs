namespace prjTypinGuide
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
            this.chkEnableSound = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStopCursor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoStopCursorOnError = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCapitalLetter = new System.Windows.Forms.CheckBox();
            this.rdoForgiveErrors = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chkEnableTextToSpeech = new System.Windows.Forms.CheckBox();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.cmbVoice = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEnableSound
            // 
            this.chkEnableSound.AutoSize = true;
            this.chkEnableSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableSound.ForeColor = System.Drawing.Color.Teal;
            this.chkEnableSound.Location = new System.Drawing.Point(21, 129);
            this.chkEnableSound.Name = "chkEnableSound";
            this.chkEnableSound.Size = new System.Drawing.Size(134, 21);
            this.chkEnableSound.TabIndex = 2;
            this.chkEnableSound.Text = "Enable sounds";
            this.chkEnableSound.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Typing Options";
            // 
            // lblStopCursor
            // 
            this.lblStopCursor.AutoSize = true;
            this.lblStopCursor.Location = new System.Drawing.Point(37, 95);
            this.lblStopCursor.Name = "lblStopCursor";
            this.lblStopCursor.Size = new System.Drawing.Size(326, 13);
            this.lblStopCursor.TabIndex = 4;
            this.lblStopCursor.Text = "If enabled, text cursor stops advancing until the right key is pressed.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Makes the text input field forgive some kinds of errors by automatically fixing t" +
    "hem.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Make extra noise when typing and on errors.";
            // 
            // rdoStopCursorOnError
            // 
            this.rdoStopCursorOnError.AutoSize = true;
            this.rdoStopCursorOnError.Checked = true;
            this.rdoStopCursorOnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStopCursorOnError.ForeColor = System.Drawing.Color.Teal;
            this.rdoStopCursorOnError.Location = new System.Drawing.Point(21, 68);
            this.rdoStopCursorOnError.Name = "rdoStopCursorOnError";
            this.rdoStopCursorOnError.Size = new System.Drawing.Size(174, 21);
            this.rdoStopCursorOnError.TabIndex = 7;
            this.rdoStopCursorOnError.TabStop = true;
            this.rdoStopCursorOnError.Text = "Stop cursor on error";
            this.rdoStopCursorOnError.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type enable capital/small letter.";
            // 
            // chkCapitalLetter
            // 
            this.chkCapitalLetter.AutoSize = true;
            this.chkCapitalLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCapitalLetter.ForeColor = System.Drawing.Color.Teal;
            this.chkCapitalLetter.Location = new System.Drawing.Point(21, 187);
            this.chkCapitalLetter.Name = "chkCapitalLetter";
            this.chkCapitalLetter.Size = new System.Drawing.Size(173, 21);
            this.chkCapitalLetter.TabIndex = 9;
            this.chkCapitalLetter.Text = "Enable capital letter";
            this.chkCapitalLetter.UseVisualStyleBackColor = true;
            // 
            // rdoForgiveErrors
            // 
            this.rdoForgiveErrors.AutoSize = true;
            this.rdoForgiveErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoForgiveErrors.ForeColor = System.Drawing.Color.Teal;
            this.rdoForgiveErrors.Location = new System.Drawing.Point(378, 68);
            this.rdoForgiveErrors.Name = "rdoForgiveErrors";
            this.rdoForgiveErrors.Size = new System.Drawing.Size(129, 21);
            this.rdoForgiveErrors.TabIndex = 11;
            this.rdoForgiveErrors.Text = "Forgive errors";
            this.rdoForgiveErrors.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Teal;
            this.btnSave.Location = new System.Drawing.Point(331, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 27);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Teal;
            this.btnClose.Location = new System.Drawing.Point(415, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 27);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enable text to speech sound.";
            // 
            // chkEnableTextToSpeech
            // 
            this.chkEnableTextToSpeech.AutoSize = true;
            this.chkEnableTextToSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableTextToSpeech.ForeColor = System.Drawing.Color.Teal;
            this.chkEnableTextToSpeech.Location = new System.Drawing.Point(21, 248);
            this.chkEnableTextToSpeech.Name = "chkEnableTextToSpeech";
            this.chkEnableTextToSpeech.Size = new System.Drawing.Size(184, 21);
            this.chkEnableTextToSpeech.TabIndex = 14;
            this.chkEnableTextToSpeech.Text = "Enable text to speech";
            this.chkEnableTextToSpeech.UseVisualStyleBackColor = true;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Location = new System.Drawing.Point(542, 319);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(125, 45);
            this.volumeTrackBar.TabIndex = 31;
            this.volumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.volumeTrackBar.Value = 50;
            this.volumeTrackBar.ValueChanged += new System.EventHandler(this.volumeTrackBar_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Volume:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Speed:";
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(344, 319);
            this.speedTrackBar.Minimum = -10;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(126, 45);
            this.speedTrackBar.TabIndex = 28;
            this.speedTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.speedTrackBar.Value = -1;
            this.speedTrackBar.ValueChanged += new System.EventHandler(this.speedTrackBar_ValueChanged);
            // 
            // cmbVoice
            // 
            this.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoice.Location = new System.Drawing.Point(134, 319);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(127, 21);
            this.cmbVoice.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Select a voice:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 446);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.speedTrackBar);
            this.Controls.Add(this.cmbVoice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkEnableTextToSpeech);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdoForgiveErrors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkCapitalLetter);
            this.Controls.Add(this.rdoStopCursorOnError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStopCursor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEnableSound);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnableSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStopCursor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoStopCursorOnError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCapitalLetter;
        private System.Windows.Forms.RadioButton rdoForgiveErrors;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkEnableTextToSpeech;
        internal System.Windows.Forms.TrackBar volumeTrackBar;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.ComboBox cmbVoice;
        internal System.Windows.Forms.Label label8;
    }
}