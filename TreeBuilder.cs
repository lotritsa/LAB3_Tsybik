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
    public class TreeBuilder
    {
        
        public TreeNode directoryTree = new TreeNode();
        string resetReport = "";
        public TreeBuilder() { }

        public string ResetTree(string path)
        {
            resetReport = "";
            directoryTree = new TreeNode();
           // directoryTree.Text = path;

            directoryTree = GetDirectories(path,path);
            /*
            foreach (string entry in Directory.GetFiles(path))
            {
                resetReport = resetReport + "File: " + entry.ToString() + Environment.NewLine;
            }
            */
            return resetReport;
        }

        

        public TreeNode GetDirectories (string path, string name)
        {
            TreeNode curDirectoryTree = new TreeNode();
            if (name[0] == 92)
            {
                name = name.Substring(1);
            }
            curDirectoryTree.Text = name;
            curDirectoryTree.Name = path;

            if (name == "Windows")
                return curDirectoryTree;
            try
            {

                foreach (string entry in Directory.GetDirectories(path))
                {
                    
                    resetReport = resetReport + "Dirertory: " + entry.ToString() + Environment.NewLine;
                    TreeNode curNextDirectoryTree = new TreeNode();
                    curNextDirectoryTree.Text = entry.Substring(path.Length);
                    curNextDirectoryTree.Name = entry;
                   
                     try
                        {

                            foreach (string nextEntry in Directory.GetDirectories(entry))
                            {
                                resetReport = resetReport + "Next Dirertory: " + nextEntry.ToString() + Environment.NewLine;
                                curNextDirectoryTree.Nodes.Add(nextEntry);

                            }
                        }
                        catch
                        {

                        }
                    
                    curDirectoryTree.Nodes.Add(curNextDirectoryTree);
                }
            }
            catch
            {

            }
            return curDirectoryTree;
        }

    }
}
