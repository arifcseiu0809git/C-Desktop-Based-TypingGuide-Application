using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace prjTypinGuide
{
	public static class mdlAPI
	{
		//=========================================================
		 public const int BeepFlag = 0; 
		 public const int HiBeep = 500; 
		 public const int LoBeep = 100; 
		 public const int LongBeep = 200; 
		 public const int ShortBeep = 100; 
		[System.Runtime.InteropServices.DllImport("kernel32")] public static extern int Beep(int dwFreq, int dwDuration);
		 public const int columnCountMax = 41; 
		 public const int lessonSizeMaxRows = 101; 
		 public const int guideSizeMaxRows = 320; 
		 public const int messageSizeMaxRows = 100;
         public const int columnCountMax_Letter = 1; 

		public struct ArrayUDT
		{
			 public char[] arrElements; 
		};

		 public static ArrayUDT []lessonX = new ArrayUDT[lessonSizeMaxRows + 1]; 
		 public static string []guideX = new string[guideSizeMaxRows + 1]; 
		 public static string []activeLessonLines = new string[lessonSizeMaxRows + 1]; 
		 public static char []studentInputX = new char[columnCountMax + 1];
         public static char[] studentInputX_Letter = new char[columnCountMax_Letter + 1];

	    public static string[] FlashText;
	    public static string[] EndFlashText;

	    public static int lessonLeangth = 0;

        public static void getFlashText()
        {
            string BasicSettingPath = Application.StartupPath + "\\tt\\BasicSettings\\BaseProperties.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(BasicSettingPath);
            XmlElement root = doc.DocumentElement;
            FlashText = new string[4];
            XmlNodeList nodes2 = root.GetElementsByTagName("Flash");
            foreach (XmlNode node in nodes2)
            {
                XmlNodeList childnodes = node.ChildNodes;
                foreach (XmlNode childnode in childnodes)
                {
                    switch (childnode.Name)
                    {
                        case "Line1":
                            FlashText[0] = childnode.InnerText;
                            break;
                        case "Line2":
                            FlashText[1] = childnode.InnerText;
                            break;
                        case "Line3":
                            FlashText[2] = childnode.InnerText;
                            break;
                        case "Line4":
                            FlashText[3] = childnode.InnerText;
                            break;
                    }
                }
                childnodes = null;
                break;
            }
        }

        public static void getEndFlashText()
        {
            string BasicSettingPath = Application.StartupPath + "\\tt\\BasicSettings\\BaseProperties.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(BasicSettingPath);
            XmlElement root = doc.DocumentElement;
            EndFlashText = new string[2];
            XmlNodeList nodes2 = root.GetElementsByTagName("EndingFlash");
            foreach (XmlNode node in nodes2)
            {
                XmlNodeList childnodes = node.ChildNodes;
                foreach (XmlNode childnode in childnodes)
                {
                    switch (childnode.Name)
                    {
                        case "Line1":
                            EndFlashText[0] = childnode.InnerText;
                            break;
                        case "Line2":
                            EndFlashText[1] = childnode.InnerText;
                            break;
                    }
                }
                childnodes = null;
                break;
            }
        }

		// main procedure to load flashing texts
        //public static void getFlashText(string pathName)
        //{

        //    string line;
        //    // Read the file and display it line by line.
        //    StreamReader file = new StreamReader(pathName);
        //    int lLineCount = 0;
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        lLineCount++;
        //    }
        //    file.Close();

        //    if (lLineCount==0)
        //        return;

        //    FlashText = new string[lLineCount];

        //    file = new StreamReader(pathName);
        //    lLineCount = 0;
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        FlashText[lLineCount] = line;
        //        lLineCount++;
        //    }
        //    file.Close();

        //}

		// main procedure to load ending flash texts
        //public static void getEndFlashText(string pathName)
        //{

        //    string line;
        //    // Read the file and display it line by line.
        //    StreamReader file = new StreamReader(pathName);
        //    int lLineCount = 0;
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        lLineCount++;
        //    }
        //    file.Close();

        //    if (lLineCount == 0)
        //        return;

        //    EndFlashText = new string[lLineCount];

        //    file = new StreamReader(pathName);
        //    lLineCount = 0;
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        EndFlashText[lLineCount] = line;
        //        lLineCount++;
        //    }
        //    file.Close();

        //}
	}
}