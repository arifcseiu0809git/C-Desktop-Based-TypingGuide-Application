namespace ScreenKeyboardControl
{
    partial class UcKeyboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxKeyboard = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftShiftDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightShiftDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxCapsLockDown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftShiftDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightShiftDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapsLockDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKeyboard
            // 
            this.pictureBoxKeyboard.Image = global::ScreenKeyboardControl.Properties.Resources.keyboard_white;
            this.pictureBoxKeyboard.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxKeyboard.Name = "pictureBoxKeyboard";
            this.pictureBoxKeyboard.Size = new System.Drawing.Size(1001, 289);
            this.pictureBoxKeyboard.TabIndex = 0;
            this.pictureBoxKeyboard.TabStop = false;
            this.pictureBoxKeyboard.SizeChanged += new System.EventHandler(this.pictureBoxKeyboard_SizeChanged);
            this.pictureBoxKeyboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxKeyboard_MouseClick);
            // 
            // pictureBoxLeftShiftDown
            // 
            this.pictureBoxLeftShiftDown.Image = global::ScreenKeyboardControl.Properties.Resources.shift_down_white;
            this.pictureBoxLeftShiftDown.Location = new System.Drawing.Point(7, 172);
            this.pictureBoxLeftShiftDown.Name = "pictureBoxLeftShiftDown";
            this.pictureBoxLeftShiftDown.Size = new System.Drawing.Size(136, 57);
            this.pictureBoxLeftShiftDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeftShiftDown.TabIndex = 1;
            this.pictureBoxLeftShiftDown.TabStop = false;
            this.pictureBoxLeftShiftDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLeftShiftDown_MouseClick);
            // 
            // pictureBoxRightShiftDown
            // 
            this.pictureBoxRightShiftDown.Image = global::ScreenKeyboardControl.Properties.Resources.shift_down_white;
            this.pictureBoxRightShiftDown.Location = new System.Drawing.Point(684, 169);
            this.pictureBoxRightShiftDown.Name = "pictureBoxRightShiftDown";
            this.pictureBoxRightShiftDown.Size = new System.Drawing.Size(136, 57);
            this.pictureBoxRightShiftDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightShiftDown.TabIndex = 2;
            this.pictureBoxRightShiftDown.TabStop = false;
            this.pictureBoxRightShiftDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRightShiftDown_MouseClick);
            // 
            // pictureBoxCapsLockDown
            // 
            this.pictureBoxCapsLockDown.Image = global::ScreenKeyboardControl.Properties.Resources.caps_down_white;
            this.pictureBoxCapsLockDown.Location = new System.Drawing.Point(7, 116);
            this.pictureBoxCapsLockDown.Name = "pictureBoxCapsLockDown";
            this.pictureBoxCapsLockDown.Size = new System.Drawing.Size(108, 57);
            this.pictureBoxCapsLockDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCapsLockDown.TabIndex = 3;
            this.pictureBoxCapsLockDown.TabStop = false;
            this.pictureBoxCapsLockDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCapsLockDown_MouseClick);
            // 
            // ucKeyboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxCapsLockDown);
            this.Controls.Add(this.pictureBoxRightShiftDown);
            this.Controls.Add(this.pictureBoxLeftShiftDown);
            this.Controls.Add(this.pictureBoxKeyboard);
            this.Name = "UcKeyboardControl";
            this.Size = new System.Drawing.Size(1013, 307);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftShiftDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightShiftDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapsLockDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKeyboard;
        private System.Windows.Forms.PictureBox pictureBoxLeftShiftDown;
        private System.Windows.Forms.PictureBox pictureBoxRightShiftDown;
        private System.Windows.Forms.PictureBox pictureBoxCapsLockDown;
    }
}
