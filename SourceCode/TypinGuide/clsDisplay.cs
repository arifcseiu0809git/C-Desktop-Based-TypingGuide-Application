using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace prjTypinGuide
{
    public class clsDisplay
    {
        //=========================================================
        // When you run the program, you will see 4 custom-made displays comprised of arrays of lbl (labels)
        // this corresponds to the top yellow display (each is about 70 units long)
        // Private lblMessage0(70) As Label

        // this corresponds to the bottom yellow display (each is about 70 units long)
        // Private lblMessage1(70) As Label

        // these two correspond to the 2 middle displays (each is about 40 units long)
        // Private lblFromCoach7(41) As Label

        // to be called FromCoach7 (custom-made) display
        // Private lblFromStudent8(41) As Label

        // to be called FromStudent8 (custom-made) display
        // the name FromCoach7 is appropriate, because on this custom-made display lesson lines (from coach) will be displayed
        // the name FromStudent8 is appropriate, because on this custom-made display student input will be displayed
        // note: nothing special attached to choice of numbers (7,8) that are used in the names FromCoach7 and FromStudent8
        // the FromCoach7 display is of dark green color, where lesson lines will be displayed
        // the FromStudent8 display is initially all gray. It is here that student input from keyboard will be displayed,
        // Many of these constant names below may not make much sense now, because these names were chosen
        // when I was working on a little more complex design. However, the purpose of these constants was
        // to help us arrange the custom displays on the monitor screen, and also to help us position each
        // unit of each custom display at some fixed distance from each other, etc etc. Also, some of the names below
        // correspond to height and width of each label used in the custom-made displays

        const int spacerMin = 1;
        const int spacerMedium = 25;
        const int spacerMax = 50;
        const int OffsetX = 5;
        const int OffsetY = 40;
        const int PbDeltaY = 0;
        const int MpDeltaY = 10;
        const int Ms0DeltaY = 18;
        const int FcDeltaY = 40;
        const int FsDeltaY = 46;
        const int TbDeltaY = 422;
        const int MsDeltaY = -55;
        //const int widthLblFC = 23;
        //const int heightLblFC = 36;

        const int widthLblMessage = 14;
        const int heightLblMessage = 16;

        const int widthLblFC = 25;
        const int heightLblFC = 36;
        const int widthLblFC_letter = 120;
        const int heightLblFC_letter = 64;
        public clsDisplay()
        {

        }

        // uses labels to create a custom-made display
        public void ShowLblFromCoachLesson(frmTypinGuide thisForm)
        {
            int fornSize = 0;
            fornSize = fornSize == 0 ? fornSize = 14 : fornSize;
            //thisForm.LblFromCoachLessonList.Clear();

            int i = 0;
            for (i = 0; i <= 40; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(OffsetX - 2 + i * (widthLblFC + spacerMin), OffsetY + FcDeltaY - 30);
                lbl.Size = new Size(widthLblFC, heightLblFC);
                lbl.BackColor = Color.FromArgb(96, 125, 139);
                lbl.ForeColor = Color.NavajoWhite;
                lbl.Font = new Font("Arrial", fornSize, FontStyle.Bold);
                lbl.Visible = true;
                lbl.Text = "";
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                thisForm.Controls.Add(lbl);
                thisForm.LblFromCoachLessonList.Add(lbl);
            }
        }

        public void ShowLblFromCoachLesson(frmTypinWord thisForm)
        {
            int fornSize = 0;
            fornSize = fornSize == 0 ? fornSize = 14 : fornSize;
            //thisForm.LblFromCoachLessonList.Clear();

            int i = 0;
            for (i = 0; i <= 40; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(OffsetX - 2 + i * (widthLblFC + spacerMin), OffsetY + FcDeltaY - 30);
                lbl.Size = new Size(widthLblFC, heightLblFC);
                lbl.BackColor = Color.FromArgb(96, 125, 139);
                lbl.ForeColor = Color.NavajoWhite;
                lbl.Font = new Font("Arrial", fornSize, FontStyle.Bold);
                lbl.Visible = true;
                lbl.Text = "";
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                thisForm.Controls.Add(lbl);
                thisForm.LblFromCoachLessonList.Add(lbl);
            }
        }

        public void ShowLblFromCoachLesson(frmTypinLetter thisForm)
        {
            int fornSize = 0;
            fornSize = fornSize == 0 ? fornSize = 44 : fornSize;
            //thisForm.LblFromCoachLessonList.Clear();

            int i = 0;
            for (i = 0; i <1; i++)
            {
                Label lbl = new Label();
                //lbl.Location = new Point(OffsetX - 2 + i * (widthLblFC + spacerMin), OffsetY + FcDeltaY - 30);
                lbl.Location = new Point(480, 54);
                lbl.Size = new Size(widthLblFC_letter, heightLblFC_letter);
                lbl.BackColor = Color.Green;
                lbl.ForeColor = Color.NavajoWhite;
                lbl.Font = new Font("Arrial", fornSize, FontStyle.Bold);
                lbl.Visible = true;
                lbl.Text = "";
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                thisForm.Controls.Add(lbl);
                thisForm.LblFromCoachLessonList.Add(lbl);
            }
        }

        // uses labels to create a custom-made display
        public void ShowLblFromStudentGivenAns(frmTypinGuide thisForm)
        {
            //thisForm.LblFromStudentGivenAnsList.Clear();
            int i = 1;
            for (i = 0; i <= 40; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(OffsetX - 2 + i * (widthLblFC + spacerMin), OffsetY + heightLblFC + FsDeltaY - 30);
                lbl.Size = new Size(widthLblFC, heightLblFC);
                lbl.BackColor = Color.Gray;
                lbl.ForeColor = Color.White;
                lbl.Font = new Font("Arrial", 14, FontStyle.Bold);
                lbl.Visible = true;
                lbl.Text = "";
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                thisForm.Controls.Add(lbl);
                thisForm.LblFromStudentGivenAnsList.Add(lbl);
            }
        }

        public void ShowLblFromStudentGivenAns(frmTypinWord thisForm)
        {
            //thisForm.LblFromStudentGivenAnsList.Clear();
            int i = 1;
            for (i = 0; i <= 40; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(OffsetX - 2 + i * (widthLblFC + spacerMin), OffsetY + heightLblFC + FsDeltaY - 30);
                lbl.Size = new Size(widthLblFC, heightLblFC);
                lbl.BackColor = Color.Gray;
                lbl.ForeColor = Color.White;
                lbl.Font = new Font("Arrial", 14, FontStyle.Bold);
                lbl.Visible = true;
                lbl.Text = "";
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                thisForm.Controls.Add(lbl);
                thisForm.LblFromStudentGivenAnsList.Add(lbl);
            }
        }

        public void ShowLblFromStudentGivenAns(frmTypinLetter thisForm)
        {
            int i = 1;
            for (i = 0; i <1; i++)
            {
                Label lbl = new Label();
                //lbl.Location = new Point(OffsetX - 2 + i * (widthLblFC + spacerMin), OffsetY + heightLblFC + FsDeltaY - 30);
                lbl.Location = new Point(480,125);
                lbl.Size = new Size(widthLblFC_letter, heightLblFC_letter);
                lbl.BackColor = Color.Gray;
                lbl.ForeColor = Color.White;
                lbl.Font = new Font("Arrial", 44, FontStyle.Bold);
                lbl.Visible = true;
                lbl.Text = "";
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                thisForm.Controls.Add(lbl);
                thisForm.LblFromStudentGivenAnsList.Add(lbl);
            }
        } 

        // use this to clear custom-made displays that are 70 units  wide
        public void clearDisplay(List<Label> displayBoard)
        {
            foreach (Label lbl in displayBoard)
            {
                lbl.Text = "";
                //lbl.BackColor = Color.Yellow;
            }
        }

        //use this to clear custom-made displays that are 41 units  wide
        public void clearShortDisplay(List<Label> displayBoard)
        {
            foreach (Label lbl in displayBoard)
            {
                lbl.Text = "";
                lbl.BackColor = Color.Gray;
            }
        }

        // this method will be used to write text to custom-made displays that are 41 units wide
        public void displayTheShortMessage(string smessage, List<Label> displayBoard)
        {
            int loopTo = smessage.Length;

            if (smessage.Length > 41)
                loopTo = 41;

            for (int i = 0; i <= loopTo; i++)
            {
                displayBoard[i].Text = smessage.Substring(i, 1);
            }
        }
        public void ClearDisplayText(List<Label> PracticeBoard)
        {
            foreach (Label lbl in PracticeBoard)
            {
                lbl.Text = "";
            }
        }

        public void displayTheMessage(string smessage, Label characterDisplayBoard)
        {

            if (smessage == null) return;
            characterDisplayBoard.Text = smessage;
        }

        public void DispalyWordWiseScore(string message, Label wordDisplayBoard)
        {
            if (message == null)
            {
                return;
            }
            wordDisplayBoard.Text = message;
        }

        public void DispalyCharacterPerminScore(string message, Label characterDisplayBoard)
        {
            if (message == null)
            {
                return;
            }
            characterDisplayBoard.Text = message;
        }



    }
}