using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjTypinGuide
{
    public partial class frmPracticeLessionList : Form
    {
        public frmPracticeLessionList()
        {
            InitializeComponent();
            GetAllLessionData();
            this.Text = GlobalVarManager.TitleMessage;
        }

        private void GetAllLessionData()
        {
            string lessonPath = string.Empty;
            List<DirectoryFiles> files = new List<DirectoryFiles>();
            if (GlobalVarManager.EnabledPageName == "PageLetter")
            {
                 lessonPath = Application.StartupPath + "\\tt\\PracticeLessons\\Letter";
            }
            else if (GlobalVarManager.EnabledPageName == "PageWord")
            {
                lessonPath = Application.StartupPath + "\\tt\\PracticeLessons\\Word";
            }
            else
            {
                lessonPath = Application.StartupPath + "\\tt\\PracticeLessons\\Sentence";
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(lessonPath);
            FileInfo[] dirFiles = directoryInfo.GetFiles();
            foreach (FileInfo fileInfo in dirFiles)
            {
                DirectoryFiles dir = new DirectoryFiles();
                dir.FileName = fileInfo.Name;
                dir.FilePathName = fileInfo.FullName;

                //using (StreamReader sr = new StreamReader(dir.FilePathName))
                using (StreamReader sr = new StreamReader(File.Open(dir.FilePathName, FileMode.Open)))
                {
                    string content = sr.ReadToEnd();
                    content = content.Length > 50 ? content.Substring(0, 50) : content;
                    dir.FileContent = content;
                }
                files.Add(dir);
            }
            //dgvLessonList.DataSource = null;
            dgvLessonList.AutoGenerateColumns = false;
            dgvLessonList.DataSource = files;
        }

        private void btnLessonUpload_Paint(object sender, PaintEventArgs e)
        {
           ControlPaint.DrawBorder(e.Graphics, btnLessonUpload.ClientRectangle,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnLessonUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Text Files | *.txt";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveFileLocDirectory = string.Empty;
                    string selectFileLoc = openFileDialog.FileName;
                    string fileName = Path.GetFileName(selectFileLoc);
                    //string saveFileLocCopy = @"E:\" + fileName;
                    if (GlobalVarManager.EnabledPageName == "PageLetter")
                    {
                        saveFileLocDirectory = Application.StartupPath + "\\tt\\PracticeLessons\\Letter";
                    }
                    else if (GlobalVarManager.EnabledPageName == "PageWord")
                    {
                        saveFileLocDirectory = Application.StartupPath + "\\tt\\PracticeLessons\\Word";
                    }
                    else
                    {
                        saveFileLocDirectory = Application.StartupPath + "\\tt\\PracticeLessons\\Sentence";
                    }
                    //string saveFileLocDirectory = Application.StartupPath + "\\tt\\PracticeLessons";

                    if (!Directory.Exists(saveFileLocDirectory))
                    {
                        Directory.CreateDirectory(saveFileLocDirectory);
                    }
                    string saveFileLocCopy = saveFileLocDirectory + "\\" + fileName;

                    string message = CommonUtility.GetCharacterCountinLine(selectFileLoc);
                    if (!string.IsNullOrEmpty(message))
                    {
                        //MessageBox.Show(message, @"Invalid Character Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(message, @"Invalid Character Length", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                        return;
                    }

                    if (File.Exists(selectFileLoc))
                    {
                        //if exists replace or do nothing
                        if (File.Exists(saveFileLocCopy))
                        {
                            DialogResult dialogResult = MessageBox.Show(@"Destination folder have this lesson, do you want to replace?", @"Replace",
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

                        //using (StreamReader strmReader = new StreamReader(selectFileLoc))
                        //{
                        //    int counter = 0;
                        //    string line;
                        //    while ((line = strmReader.ReadLine()) != null)
                        //    {
                        //        if (!string.IsNullOrEmpty(line) && line.Length > 39)
                        //        {
                        //            MessageBox.Show(
                        //                @"Practice session can not have more than 39 character in a line. Please provide witin 39 character" + Convert.ToChar( 13).ToString()+
                        //                line +"(Length " + line.Length+ ")",
                        //                @"Character Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //            return;
                        //        }
                        //        counter ++;
                        //    }
                        //}

                        File.Copy(selectFileLoc, saveFileLocCopy);
                    }
                }
            }
            GetAllLessionData();
        }

        private void frmPracticeLessionList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //frmTypinGuide frm=new frmTypinGuide();
            //frm.ShowDialog();
        }
        //private void frmPracticeLessionList_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Application.Restart();

        //}
       
        private void btnLessonDel_Click(object sender, EventArgs e)
        {
            var test=  dgvLessonList.SelectedRows;

            if (dgvLessonList.SelectedRows.Count != 0)
            {
                int rowIndex = dgvLessonList.CurrentCell.RowIndex;
                string selectedFileName = dgvLessonList.Rows[rowIndex].Cells[0].Value.ToString();
                string fileLocation = string.Empty;

                if (!string.IsNullOrEmpty(selectedFileName))
                {
                DialogResult dialog=    MessageBox.Show("Dou you want to delete the file " + selectedFileName+"?", "Delete file",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialog == DialogResult.Yes)
                    {
                        if (GlobalVarManager.EnabledPageName == "PageLetter")
                        {
                            fileLocation = Application.StartupPath + "\\tt\\PracticeLessons\\Letter\\" + selectedFileName;
                        }
                        else if (GlobalVarManager.EnabledPageName == "PageWord")
                        {
                            fileLocation = Application.StartupPath + "\\tt\\PracticeLessons\\Word\\" + selectedFileName;
                        }
                        else
                        {
                            fileLocation = Application.StartupPath + "\\tt\\PracticeLessons\\Sentence" + selectedFileName;
                        }
                        //string fileLocation = Application.StartupPath + "\\tt\\PracticeLessons\\" + selectedFileName;
                        File.Delete(fileLocation);
                    }
                }


                GetAllLessionData();


            }
        }
    }

    public class DirectoryFiles
    {
        public String FileName { get; set; }
        public string FileContent { get; set; }
        public string FilePathName { get; set; }

    }
}
