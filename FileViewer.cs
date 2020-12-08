using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_30
{
    public class FileViewer
    {
        public FileViewer() { }
        public List<string> filesList = new List<string>();

        public void getFiles(string path)
        {
            filesList.Clear();
            try
            {

                foreach (string entry in Directory.GetFiles(path))
                {
                    string name = entry.Substring(path.Length);
                    if (name[0] == 92) name = name.Substring(1);
                    filesList.Add(name);
                }
            }
            catch
            {

            }
            //return filesList;
        }

        public void UpdateShowedFileList (string chosedExtension)
        {
            if (chosedExtension == "" || chosedExtension[0] == 'A') return;
            else if (chosedExtension[0] == 'T') chosedExtension = "txt";
            else if (chosedExtension[0] == 'H') chosedExtension = "html";
            else if (chosedExtension[0] == 'X') chosedExtension = "xml"; 
            FileViewer newRightFileViewer = new FileViewer();
            foreach (string curFile in this.filesList)
            {
                string[] kek = curFile.Split('.');
                string curExtension = kek[kek.Length - 1];
                if (curExtension == chosedExtension)
                {
                    newRightFileViewer.filesList.Add(curFile);
                }

            }
            this.filesList = newRightFileViewer.filesList;
        }
    }
}
