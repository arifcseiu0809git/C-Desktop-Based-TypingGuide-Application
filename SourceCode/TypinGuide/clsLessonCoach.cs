using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace prjTypinGuide
{
    public class clsLessonCoach
    {
        public string textFileName7;
        //this will hold the pathname to the text file called GuideX1
        //GuideX1.txt is a file where messages are stored to guide a student to make a right choice of fingers to strike a given key.
        //For example, if the student at any point in his typing drill is required to strike the 'F' or the 'R' OR the 'V' key,
        //to help him choose the LEFT INDEX finger, the ascii values for F, R, and V keys are mapped to corresponding line numbers inside
        //the GuideX1.txt file with the following message, "Use F-finger, ie. the Left Index finger".
        //It is highly instructive that you go ahead, open the GuideX1.txt file located in \tt folder, and verify the above remarks
        //Also, please run the TypinGuide program at this time to see if all this makes sense.


        //As you will soon find out, the textbox2.KeyPress() event is the key engine of this application.
        //This textbox2.KeyPress() event and the corresponding routine is at the core of the typinGuide applet
        //It is this routine that displays lesson lines, processes keyboard input from student, and displays
        //it on the screen. With the KB_ActiveFlag (below) we can control when to allow textbox2.KeyPress() routine to run,
        //and when not to run.
        public bool KB_ActiveFlag;
        //By setting KB_ActiveFlag to FALSE we can have the code inside textbox2.KeyPress() routine to be skipped
        //The idea is to avoid using textbox2.KeyPress() for things other than typing drills

        //The following constants define the size of arrays to be declared shortly
        //The above defined constant values set a limit on the size of the text files from where
        //text will be read and stored into arrays defined below:

        public int x = 0;
        //the above keeps track of the character position

        public int activeRow;
        //the above tracks the lesson row being used currently

        public int rowCountForActiveLesson;
        //the above stores the total number of rows read from a lesson file (ie. ex.txt file described earlier)

        public int rowCountForActiveMessage;
        //the above stores the total number of rows read from a message file

        public int rowCountForGuideX;
        //the above variable stores the total number of rows in the GuideX file

        public int stateX;
        //the above is used by the textbox2.KeyPress() event to determine wheteher the current row is done
        //If still not done, it will assume a value of 0. If done it will take 1. In the case its done,
        //it will be further deteremined if this row happened to be the last row.
        //The routine, named, "SetState()"  comes later that has the code to determine the correct state
        //for stateX variable defined above

        public bool InputMatch;
        //the above is used to help grade student's input against the required input

        //these counters keep track of hits/misses (ie. correct vs in-correct keystrokes by student)
        public int IncorrectCharacterCount;
        public int CorrectCharacterCount;
        public int TotalLine;

        public int CorrectWordCount;
        public int IncorrectWordCount;       
        public clsLessonCoach()
        {

            KB_ActiveFlag = false;
            activeRow = 0;
            InputMatch = false;
            IncorrectCharacterCount = 0;
            CorrectCharacterCount = 0;
        }

        public void SetState()
        {
             if (x < mdlAPI.lessonX[activeRow].arrElements.Length - 1)
            {
                x++;
                stateX = 0; //i ndicates still on same row
            }
            else
            {
                activeRow++;
                x = 0;
                stateX = 1; //i ndicates next  row within  current lesson 

                if (activeRow > rowCountForActiveLesson - 1)
                {
                    //p repare for next lesson
                    stateX = 2;
                    //e nd of  last row  of current lesson, so go to next lesson
                    KB_ActiveFlag = false;
                }
            }
        }


        //What follows next,  are the file i/o methods for reading lines of text into arrays defined earlier
        //this method opens the lesson file holding the typing lesson (drill) and reads it
        //copying each row of text to a corresponding row, lessonX[i], in the lessonX[][]jagged array
        public void getNewLesson(string pathName)
        {
            mdlAPI.lessonLeangth = 0;
            string sNextLine;
            // nFileNum = FreeFile;
            int counter = 0;
            string line;
            // Read the file and display it line by line.
            StreamReader file = new StreamReader(pathName);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Length > 39)
                {
                    MessageBox.Show(
                        "TG does not allow more than 39 charecters in a line." + Convert.ToChar(13).ToString() +
                        " Correct it than start. ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                mdlAPI.lessonLeangth += line.Length;
                mdlAPI.lessonX[counter].arrElements = str2Array(line);
                mdlAPI.activeLessonLines[counter] = line;
                counter++;
            }

            file.Close();
            if (counter > 100)//101
            {
                MessageBox.Show(
                    "TG does not allow more than 20 line in a lesson." + Convert.ToChar(13).ToString() +
                    " Correct it than start. ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }

            TotalLine = counter;
            rowCountForActiveLesson = counter; //records row total for the new lesson
        }

        public bool getNewLessonForLetter(string pathName)
        {
            bool isCorret = true; ;
            mdlAPI.lessonLeangth = 0;
            string sNextLine;
            // nFileNum = FreeFile;
            int counter = 0;
            string line;
            // Read the file and display it line by line.
            StreamReader file = new StreamReader(pathName);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Length > 1)
                {
                    MessageBox.Show(
                        "TG does not allow more than 1 charecters in a line." + Convert.ToChar(13).ToString() +
                        " Correct it than start. ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Application.Exit();
                    isCorret = false;
                    break;
                }
                mdlAPI.lessonLeangth += line.Length;
                mdlAPI.lessonX[counter].arrElements = str2Array(line);
                mdlAPI.activeLessonLines[counter] = line;
                counter++;
            }

            file.Close();
            if (counter > 100)//101
            {
                MessageBox.Show(
                    "TG does not allow more than 20 line in a lesson." + Convert.ToChar(13).ToString() +
                    " Correct it than start. ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isCorret = false;
                Application.Exit();
            }

            TotalLine = counter;
            rowCountForActiveLesson = counter; //records row total for the new lesson
            return isCorret;

        }

        public bool getNewLessonForWord(string pathName)
        {
            bool isCorret = true; ;
            mdlAPI.lessonLeangth = 0;
            string sNextLine;
            // nFileNum = FreeFile;
            int counter = 0;
            string line;
            // Read the file and display it line by line.
            StreamReader file = new StreamReader(pathName);
            while ((line = file.ReadLine()) != null)
            {

                //string text = "sossjj ssskkk";
                //line = line.Trim();
                int words = line.Split(' ').Length;

                if (words>2)
                {
                    MessageBox.Show(
                        "TG does not allow more than 1 word in a line." + Convert.ToChar(13).ToString() +
                        " Correct it than start. ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Application.Exit();
                    isCorret = false;
                    break;
                }
                mdlAPI.lessonLeangth += line.Length;
                mdlAPI.lessonX[counter].arrElements = str2Array(line);
                mdlAPI.activeLessonLines[counter] = line;
                counter++;
            }

            file.Close();
            if (counter > 100)//101
            {
                MessageBox.Show(
                    "TG does not allow more than 20 line in a lesson." + Convert.ToChar(13).ToString() +
                    " Correct it than start. ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isCorret = false;
                Application.Exit();
            }

            TotalLine = counter;
            rowCountForActiveLesson = counter; //records row total for the new lesson
            return isCorret;

        }

        //this method opens the file holding guiding messages to help student choose the right finger to strike a given key
        public void GetGuideX(string pathName)
        {
            string sNextLine;
            StreamReader file = new StreamReader(pathName);
            int lLineCount = 0;
            string line;
            while ((line = file.ReadLine()) != null)
            {
                mdlAPI.guideX[lLineCount] = line;
                lLineCount++;
            }

            file.Close();
            rowCountForGuideX = lLineCount;
        }


        //once the lesson file is copied to a lessonX[][] jagged array of characters,
        //each row from it is read out for display to the custom-made display (eg. the FromCoach7 display)
        public void displayNewLesson(List<Label> displayBoard, int fontSize)
        {
            //int fontSize = 22;
            fontSize = fontSize == 0 ? fontSize = 14 : fontSize;

            for (int i = 0; i < mdlAPI.lessonX[activeRow].arrElements.Length; i++)
            {
                if (mdlAPI.lessonX[activeRow].arrElements[i] == '&')
                {
                    displayBoard[i].Text = "&&"; //this part of the code is needed to display the char '&' properly
                    displayBoard[i].Font = new Font("Arrial", fontSize, FontStyle.Bold);
                }
                else
                {
                    displayBoard[i].Text = mdlAPI.lessonX[activeRow].arrElements[i].ToString();
                    displayBoard[i].Font = new Font("Arrial", fontSize, FontStyle.Bold);
                }
            }
            //int a = displayBoard.Count;
            //int b = mdlAPI.lessonX[activeRow].arrElements.Length;
            //displayBoard.RemoveRange(b, a - b);  
        }

        public void displayNewLesson_Letter(List<Label> displayBoard, int fontSize)
        {
            //int fontSize = 22;
            fontSize = fontSize == 0 ? fontSize = 44 : fontSize;
            if (mdlAPI.lessonX[activeRow].arrElements.Length>1)
            {
                MessageBox.Show("Only single letter are allowed.");
                return;
            }

            for (int i = 0; i < mdlAPI.lessonX[activeRow].arrElements.Length; i++)
            {
                if (mdlAPI.lessonX[activeRow].arrElements[i] == '&')
                {
                    displayBoard[i].Text = "&&"; //this part of the code is needed to display the char '&' properly
                    displayBoard[i].Font = new Font("Arrial", fontSize, FontStyle.Bold);
                }
                else
                {
                    displayBoard[i].Text = mdlAPI.lessonX[activeRow].arrElements[i].ToString();
                    displayBoard[i].Font = new Font("Arrial", fontSize, FontStyle.Bold);
                }
            }
            //int a = displayBoard.Count;
            //int b = mdlAPI.lessonX[activeRow].arrElements.Length;
            //displayBoard.RemoveRange(b, a - b);  
        }



        private char[] str2Array(string xString)
        {
            char[] returnValue = { };

            if (xString.Length == 0)
            {
                MessageBox.Show(
                    "TG Does Not Allow Empty Line." + Convert.ToChar(13).ToString() +
                    " Correct it than start. ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
                return returnValue;
            }

            returnValue = new char[xString.Length];
            int i = 0;
            foreach (char c in xString)
            {
                returnValue[i] = c;
                i++;
            }
            return returnValue;
        }

        public string GetTitle(string pathName)
        {
            return System.IO.File.ReadAllText(pathName);
        }


        //As the student enters his/her input from the keyboard, all keypressed are stored in
        //the studentInputX[] character array. From here, the contents are displayed
        //onto the custom-made display (eg. FromStudent8 display)
        //This method uses InputMatch variable of the class to grade student input against
        //the required input.
        //Also, in this method the next position for the cursor is determined
        public void displayStudentInputX(List<Label> displayBoard) //, char displayBoardKey
        {
            displayBoard[x].BackColor = InputMatch == true ? Color.Green : Color.HotPink;
            switch (mdlAPI.studentInputX[x])
            {
                case '&':
                    displayBoard[x].Text = "&&"; //this part of the code is needed to display the char '&' properly
                    break;
                default:
                    if (GlobalVarManager.EnableCapitalLetter)
                    {
                        displayBoard[x].Text = mdlAPI.studentInputX[x].ToString();
                    }
                    else
                    {
                        //displayBoard[x].Text = mdlAPI.studentInputX[x].ToString().ToLower();
                        displayBoard[x].Text = mdlAPI.studentInputX[x].ToString();
                    }
                    break;
            }
            if (x >= mdlAPI.lessonX[activeRow].arrElements.Length) return;
            displayBoard[x + 1].BackColor = Color.LightSeaGreen;
        }

        public void displayStudentInputX_Letter(List<Label> displayBoard) //, char displayBoardKey
        {
            displayBoard[x].BackColor = InputMatch == true ? Color.Green : Color.HotPink;
            switch (mdlAPI.studentInputX_Letter[x])
            {
                case '&':
                    displayBoard[x].Text = "&&"; //this part of the code is needed to display the char '&' properly
                    break;
                default:
                    if (GlobalVarManager.EnableCapitalLetter)
                    {
                        displayBoard[x].Text = mdlAPI.studentInputX_Letter[x].ToString();
                    }
                    else
                    {
                        displayBoard[x].Text = mdlAPI.studentInputX_Letter[x].ToString().ToLower();
                    }
                    break;
            }
            if (x >= mdlAPI.lessonX[activeRow].arrElements.Length)
                return;
            displayBoard[x].BackColor = Color.LightSeaGreen;
        }


        // used inside textbox2.KeyPress() event to clear the contents of the custom-made display (ie. FromStudent8)
        public void clearDisplayFromStudent(List<Label> displayBoard)
        {
            int i;
            for (i = 0; i <= mdlAPI.columnCountMax - 1; i++)
            {
                displayBoard[i].Text = " ";
                displayBoard[i].BackColor = Color.Gray; // May want to comment this line out
                displayBoard[i].BorderStyle = BorderStyle.None;
            }
        }

        public void clearDisplayFromStudent_Letter(List<Label> displayBoard)
        {
            int i;	
            for (i = 0; i <= mdlAPI.columnCountMax_Letter - 1; i++)
            {
                displayBoard[i].Text = " ";
                displayBoard[i].BackColor = Color.Gray; // May want to comment this line out
                displayBoard[i].BorderStyle = BorderStyle.None;
            }
        }

        // used inside textbox2.KeyPress() event to clear the contents of the custom-made display (ie. FromCoach7)
        public void clearDisplayFromCoach(List<Label> displayBoard)
        {
            int i;	// - "AutoDim" 
            for (i = 0; i <= mdlAPI.columnCountMax - 1; i++)
            {
                // added -1
                displayBoard[i].Text = " ";
                displayBoard[i].BackColor = Color.Green; // May want to comment this line out
                // displayBoard(i).BorderStyle = 0
            }
        }

        public void clearDisplayFromCoach_Letter(List<Label> displayBoard)
        {
            int i;

            for (i = 0; i <= mdlAPI.columnCountMax_Letter - 1; i++)
            {
                displayBoard[i].Text = " ";
                displayBoard[i].BackColor = Color.Green; // May want to comment this line out
                // displayBoard(i).BorderStyle = 0
            }
        }
    }
}
