using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace prjTypinGuide
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (getPrevInstance())
            {
                Application.Exit();
            }
            else
            {
                if (!CheckFilesExist())
                {
                    string fileNames = string.Empty;
                    //string fileNames = Convert.ToChar(13).ToString() + "1. Title1.txt" ;
                    fileNames += Convert.ToChar(13).ToString() + "1. guideX1.txt";
                    //fileNames += Convert.ToChar(13).ToString() + "3. ex.txt";
                    //fileNames += Convert.ToChar(13).ToString() + "3. Flash.txt";
                    //fileNames += Convert.ToChar(13).ToString() + "4. EndingFlash.txt";

                    MessageBox.Show("Following files should be placed in - "  + Application.StartupPath + "\\tt\\" + fileNames);
                    Application.Exit();
                    return;
                }              
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmTypinGuide());
                Application.Run(new frmMain());
            }
        }
        private static bool CheckFilesExist()
        {
            //if (!System.IO.File.Exists(Application.StartupPath + "\\tt\\Title1.txt"))
            //    return false;

            if (!System.IO.File.Exists(Application.StartupPath + "\\tt\\guideX1.txt"))
                return false;
            //if (!System.IO.File.Exists(Application.StartupPath + "\\tt\\ex.txt"))
            //    return false;
            //if (!System.IO.File.Exists(Application.StartupPath + "\\tt\\Flash.txt"))
            //    return false;
            //if (!System.IO.File.Exists(Application.StartupPath + "\\tt\\EndingFlash.txt"))
            //    return false;
            
            return true;
        }

        private static bool getPrevInstance()
        {
            //get the name of current process, i,e the process 
            //name of this current application
            string currPrsName = Process.GetCurrentProcess().ProcessName;
            //Get the name of all processes having the 
            //same name as this process name 
            Process[] allProcessWithThisName= Process.GetProcessesByName(currPrsName);

            //if more than one process is running return true.
            //which means already previous instance of the application 
            //is running
            if (allProcessWithThisName.Length > 1)
            {
                return true; // Yes Previous Instance Exist
            }
            else
            {
                return false; //No Prev Instance Running
            }
        }
    }
}
