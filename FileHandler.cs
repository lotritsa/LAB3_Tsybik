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
    public class FileHandler
    {
        public FileHandler() { }

        public List<string> CopyListOfFiles (List <string> filesToCopy, string path)
        {
            List<string> newfiles = new List<string>();
            if (path[path.Length - 1] != 92) path = path +  Convert.ToChar (92);
            foreach (string entry in filesToCopy)
            {
                newfiles.Add(CopyFile(entry,path));
            }
            return newfiles;
        }

        public string CopyFile (string FileToCopy, string path)
        {
            string[] kek = FileToCopy.Split('.');
            string name = kek[0] + "_copy";
            string extencion = '.' + kek[1];
            if (File.Exists(path + name + extencion))
            {
                int i = 1;
                while (File.Exists(path+ name + '(' + i.ToString() + ')' + extencion))
                {
                    i++;
                }
                name = name + '(' + i.ToString() + ')';
            }
            File.Copy(path + FileToCopy, path + name + extencion);
            return name + extencion;
        }
        public List <string> DeleteListOfFiles (List <string> filesToDelete, string path)
        {
            List<string> deletedFiles = new List<string>();
            if (path[path.Length - 1] != 92) path = path + Convert.ToChar(92);
            foreach (string entry in filesToDelete)
            {
                if (File.Exists(path + entry))
                {
                    File.Delete(path + entry);
                    deletedFiles.Add(entry);
                }
            }
            return deletedFiles;
        }

        public List <string> MoveListOfFiles (List <string> filesToMove, string path1, string path2)
        {
            List<string> movedFiles = new List<string>();
            if (path1[path1.Length - 1] != 92) path1 = path1 + Convert.ToChar(92);
            if (path2[path2.Length - 1] != 92) path2 = path2 + Convert.ToChar(92);

            foreach (string entry in filesToMove)
            {
                if (File.Exists(path1+entry))
                {
                    string[] kek = entry.Split('.');
                    string name = kek[0];
                    string extencion = '.' + kek[1];
                    if (File.Exists(path2 + name + extencion))
                    {
                        int i = 1;
                        while (File.Exists(path2 + name + '(' + i.ToString() + ')' + extencion))
                        {
                            i++;
                        }
                        name = name + '(' + i.ToString() + ')';
                    }
                    File.Copy(path1 + entry, path2 + name + extencion);

                    File.Delete(path1+entry);
                    movedFiles.Add(entry);
                }
            }

            return movedFiles;
        }
    }
}
