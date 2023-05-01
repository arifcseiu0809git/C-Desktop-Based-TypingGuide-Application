using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjTypinGuide.Properties;

namespace prjTypinGuide
{
    public static class CommonUtility
    {
        public static string GetCharacterCountinLine(string phsycalFileLocation)
        {
            string message = string.Empty;
            string currentLine;
            int countLine = 0;
            using (StreamReader streamReader = new StreamReader(phsycalFileLocation))
            {
                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(currentLine) && currentLine.Length > 39)
                    {
                        //message = "Practice session can not have more than 39 character in a line. Please provide witin 39 character." + Convert.ToChar(13).ToString()+ currentLine + " (Length is " + currentLine.Length +")";
                        message = "Practice session can not have more than 39 character in a line. Please provide witin 39 character." + " (This message length is " + currentLine.Length + ")";
                        return message;
                    }
                    if (string.IsNullOrEmpty(currentLine) || currentLine.Length == 0)
                    {
                       message = "TG does not allow empty line." + Convert.ToChar(13).ToString() +" Correct it then start";
                    }
                    countLine++;
                }
                if (countLine==0)
                {
                    message = "TG does not allow empty lesson.";
                }
                else if (countLine > 20)
                {
                    //MessageBox.Show(
                    //    Resources.LessonLengthMoreThan20Lines + Convert.ToChar(13).ToString() +
                    //    @" Correct it than start. ", @"Line is more than 20", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Application.Exit();
                    message = "TGdoes not allow more than 20 line. (Lesson line number is " + countLine + ")";
                }
            }
            return message;
        }
    }
}
