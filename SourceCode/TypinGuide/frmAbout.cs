using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjTypinGuide
{
    public partial class frmAbout : Form
    {
        //private clsLessonCoach _clsLessonCoach = new clsLessonCoach();
        public frmAbout()
        {
            
            string year = Convert.ToString(DateTime.Now.Year);      
            InitializeComponent();
            this.Text = GlobalVarManager.TitleMessage;
            lblProject.Text = "Typing Guide version: "+ year;
            lblCopyright.Text = "Copyright @" + year + ". All rights reserved.";
        }
    }
}
