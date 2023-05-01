using System.Drawing;

namespace prjTypinGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSingleLetter = new System.Windows.Forms.Button();
            this.btnSingleWord = new System.Windows.Forms.Button();
            this.btnSingleSentence = new System.Windows.Forms.Button();
            this.btnOthers = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSingleLetter
            // 
            this.btnSingleLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSingleLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleLetter.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSingleLetter.Location = new System.Drawing.Point(498, 26);
            this.btnSingleLetter.Name = "btnSingleLetter";
            this.btnSingleLetter.Size = new System.Drawing.Size(138, 71);
            this.btnSingleLetter.TabIndex = 0;
            this.btnSingleLetter.Text = "Single Letter";
            this.btnSingleLetter.UseVisualStyleBackColor = false;
            this.btnSingleLetter.Click += new System.EventHandler(this.btnSingleLetter_Click);
            this.btnSingleLetter.MouseLeave += new System.EventHandler(this.btnSingleLetter_MouseLeave);
            this.btnSingleLetter.MouseHover += new System.EventHandler(this.btnSingleLetter_MouseHover);
            // 
            // btnSingleWord
            // 
            this.btnSingleWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSingleWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleWord.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSingleWord.Location = new System.Drawing.Point(498, 139);
            this.btnSingleWord.Name = "btnSingleWord";
            this.btnSingleWord.Size = new System.Drawing.Size(138, 66);
            this.btnSingleWord.TabIndex = 1;
            this.btnSingleWord.Text = "Single Word";
            this.btnSingleWord.UseVisualStyleBackColor = false;
            this.btnSingleWord.Click += new System.EventHandler(this.btnSingleWord_Click);
            this.btnSingleWord.MouseLeave += new System.EventHandler(this.btnSingleWord_MouseLeave);
            this.btnSingleWord.MouseHover += new System.EventHandler(this.btnSingleWord_MouseHover);
            // 
            // btnSingleSentence
            // 
            this.btnSingleSentence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSingleSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleSentence.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSingleSentence.Location = new System.Drawing.Point(498, 251);
            this.btnSingleSentence.Name = "btnSingleSentence";
            this.btnSingleSentence.Size = new System.Drawing.Size(138, 69);
            this.btnSingleSentence.TabIndex = 2;
            this.btnSingleSentence.Text = "Single Sentence";
            this.btnSingleSentence.UseVisualStyleBackColor = false;
            this.btnSingleSentence.Click += new System.EventHandler(this.btnSingleSentence_Click);
            this.btnSingleSentence.MouseLeave += new System.EventHandler(this.btnSingleSentence_MouseLeave);
            this.btnSingleSentence.MouseHover += new System.EventHandler(this.btnSingleSentence_MouseHover);
            // 
            // btnOthers
            // 
            this.btnOthers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnOthers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnOthers.Location = new System.Drawing.Point(671, 25);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(138, 71);
            this.btnOthers.TabIndex = 3;
            this.btnOthers.Text = "Useful Links";
            this.btnOthers.UseVisualStyleBackColor = false;
            this.btnOthers.MouseLeave += new System.EventHandler(this.btnOthers_MouseLeave);
            this.btnOthers.MouseHover += new System.EventHandler(this.btnOthers_MouseHover);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHelp.Location = new System.Drawing.Point(671, 139);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(138, 66);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnHelp_MouseLeave);
            this.btnHelp.MouseHover += new System.EventHandler(this.btnHelp_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnExit.Location = new System.Drawing.Point(671, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 69);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(130, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "Typing Guide";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(836, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnOthers);
            this.Controls.Add(this.btnSingleSentence);
            this.Controls.Add(this.btnSingleWord);
            this.Controls.Add(this.btnSingleLetter);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Guide";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingleLetter;
        private System.Windows.Forms.Button btnSingleWord;
        private System.Windows.Forms.Button btnSingleSentence;
        private System.Windows.Forms.Button btnOthers;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}