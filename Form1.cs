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
    
    public partial class Form1 : Form
    {
        TreeBuilder leftTree = new TreeBuilder();
        TreeBuilder rightTree = new TreeBuilder();

        FileViewer leftFileViewer = new FileViewer();
        FileViewer rightFileViewer = new FileViewer();

        public FileViewer leftFileViewerShowed = new FileViewer();
        FileViewer rightFileViewerShowed = new FileViewer();

        Observer leftDiskObserwer = new Observer();
        Observer rightDiskObserver = new Observer();
       
        List<string> diskList = new List<string>();
        List<string> fileTypesList = new List<string>();

        FileHandler leftFileHandler = new FileHandler();

        ImageList icons = new ImageList();

        
        public Form1()
        {
            InitializeComponent();
            InitWorkspace();
        }
        private void InitWorkspace ()
        {
            diskList.Add(@"C:\");
            diskList.Add(@"D:\");
            diskList.Add(@"E:\");
            fileTypesList.Add("ALL files");
            fileTypesList.Add("TEXT files (*.txt)");
            fileTypesList.Add("HTML files (*.html)");
            fileTypesList.Add("XML files (*.xml)");
            foreach (string curDisk in diskList)
            {
                leftDiskBox.Items.Add(curDisk);
                rightDiskBox.Items.Add(curDisk);
            }
            foreach (string curFileType in fileTypesList)
            {
                leftFileTypeBox.Items.Add(curFileType);
                rightFileTypeBox.Items.Add(curFileType);
            }
            icons.Images.Add("foledClosed", Image.FromFile(@"C:\lab3\folder_closed.png"));
            icons.Images.Add("folderOpened", Image.FromFile(@"C:\lab3\folder_opened.png"));
            leftTreeView.ImageList = icons;
            rightTreeView.ImageList = icons;

            leftTreeView.ImageKey = "folderClosed";
            leftTreeView.SelectedImageKey = "folderOpened";

            rightTreeView.ImageKey = "folderClosed";
            rightTreeView.SelectedImageKey = "folderOpened";
        }

        private void UpdateLeftFileView(string path)
        {

            leftFileViewer.getFiles(path);
            string chosedExtension = "";
            if (leftFileTypeBox.Text != "") chosedExtension = leftFileTypeBox.SelectedItem.ToString();
            leftFileViewerShowed.filesList = leftFileViewer.filesList;
            leftFileViewerShowed.UpdateShowedFileList(chosedExtension);

            leftFileView.Clear();
            for (int i = 0; i < leftFileViewerShowed.filesList.Count; i++)
            {
                leftFileView.Items.Add(leftFileViewerShowed.filesList[i]);
            }
        }
        private void UpdateRightFileView(string path)
        {

            rightFileViewer.getFiles(path);
            string chosedExtension = "";
            if (rightFileTypeBox.Text != "") chosedExtension = rightFileTypeBox.SelectedItem.ToString();
            rightFileViewerShowed.filesList = rightFileViewer.filesList;
            rightFileViewerShowed.UpdateShowedFileList(chosedExtension);
            rightFileView.Clear();

            for (int i = 0; i < rightFileViewerShowed.filesList.Count; i++)
            {
                rightFileView.Items.Add(rightFileViewerShowed.filesList[i]);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Name.ToString();
            UpdateLeftFileView(path);
        }

        private void rightTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Name.ToString();
            UpdateRightFileView(path);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GetObserverMessage()
        {


            string message = "Received a tree change message!";
            string caption = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);

            leftTree.ResetTree(leftDiskBox.Text.ToString());
           
            leftTreeView.Nodes.Clear();
            leftTreeView.Nodes.Add(leftTree.directoryTree);
            rightTree.ResetTree(rightDiskBox.Text.ToString());
            
            rightTreeView.Nodes.Clear();
            rightTreeView.Nodes.Add(rightTree.directoryTree);
        }
            
        private void leftDiskBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftDiskObserwer.Stop();
            string kek = leftTree.ResetTree(leftDiskBox.Text.ToString());
            debugTextBox.Text = kek;
            leftTreeView.Nodes.Clear();
            leftTreeView.Nodes.Add(leftTree.directoryTree);
            leftDiskObserwer.Start(leftDiskBox.Text.ToString(),this);

        }

        private void rightDiskBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rightDiskObserver.Stop();
            string kek = rightTree.ResetTree(rightDiskBox.Text.ToString());
            debugTextBox.Text = kek;
            rightTreeView.Nodes.Clear();
            rightTreeView.Nodes.Add(rightTree.directoryTree);
            rightDiskObserver.Start(rightDiskBox.Text.ToString(),this);
        }


        private void leftTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            int curNodeCount = e.Node.Nodes.Count;
            TreeNode newNode = new TreeNode();
            for (int i = 0; i < curNodeCount; i++)
            {

                newNode.Nodes.Add(leftTree.GetDirectories(e.Node.Nodes[i].Name, e.Node.Nodes[i].Text));

            }
            e.Node.Nodes.Clear();
            foreach (TreeNode kek in newNode.Nodes)
            {
                e.Node.Nodes.Add(kek);
            }

        }

        private void rightTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

            int curNodeCount = e.Node.Nodes.Count;
            TreeNode newNode = new TreeNode();
            for (int i = 0; i < curNodeCount; i++)
            {

                newNode.Nodes.Add(leftTree.GetDirectories(e.Node.Nodes[i].Name, e.Node.Nodes[i].Text));

            }
            e.Node.Nodes.Clear();
            foreach (TreeNode kek in newNode.Nodes)
            {
                e.Node.Nodes.Add(kek);
            }
        }

        private void leftFileTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string chosedExtension = leftFileTypeBox.SelectedItem.ToString();
            leftFileViewerShowed.filesList = leftFileViewer.filesList;
            leftFileViewerShowed.UpdateShowedFileList(chosedExtension);
            if (leftTreeView.SelectedNode != null)
            {
                UpdateLeftFileView(leftTreeView.SelectedNode.Name);
            }
        }

        private void rightFileTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chosedExtension = rightFileTypeBox.SelectedItem.ToString();
            rightFileViewerShowed.filesList = rightFileViewer.filesList;
            rightFileViewerShowed.UpdateShowedFileList(chosedExtension);
            if (rightTreeView.SelectedNode != null)
            {
                UpdateRightFileView(rightTreeView.SelectedNode.Name);
            }
        }


        public Info openedForm = null;
        private void button7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                openedForm = new Info();
                openedForm.Show();
            }
            else
            {
                openedForm.Show();
            }
        } 

        private void button2_Click(object sender, EventArgs e) //delete
        {
            List<string> selectedFilesList = new List<string>();
            bool prov = true;
            if (leftTreeView.SelectedNode != null)
            {
                string path = leftTreeView.SelectedNode.Name;
                foreach (ListViewItem entry in leftFileView.SelectedItems)
                {
                    selectedFilesList.Add(entry.Text);
                }
                leftFileHandler.DeleteListOfFiles(selectedFilesList, path);

                if (leftTreeView.SelectedNode != null)
                {
                    UpdateLeftFileView(leftTreeView.SelectedNode.Name);
                }
                if (rightTreeView.SelectedNode != null)
                {
                    UpdateRightFileView(rightTreeView.SelectedNode.Name);
                }
            }
            else
            {
                prov = false;
            }
            if (!prov)
            {
                string message = "Delete failed!";
                string caption = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void button1_Click(object sender, EventArgs e) //copy
        {
            List<string> selectedFilesList = new List<string>();
            bool prov = true;
            if (leftTreeView.SelectedNode != null)
            {
                string path = leftTreeView.SelectedNode.Name;
                foreach (ListViewItem entry in leftFileView.SelectedItems)
                {
                    selectedFilesList.Add(entry.Text);
                }
                leftFileHandler.CopyListOfFiles(selectedFilesList, path);
                if (leftTreeView.SelectedNode != null)
                {
                    UpdateLeftFileView(leftTreeView.SelectedNode.Name);
                }
                if (rightTreeView.SelectedNode != null)
                {
                    UpdateRightFileView(rightTreeView.SelectedNode.Name);
                }
            }
            else
            {
                prov = false;
            }
            if (!prov)
            {
                string message = "Сopy failed!";
                string caption = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void button3_Click(object sender, EventArgs e) //move
        {

            List<string> selectedFilesList = new List<string>();
            bool prov = true;
            if (leftTreeView.SelectedNode != null && rightTreeView.SelectedNode != null)
            {
                string path1 = leftTreeView.SelectedNode.Name;
                string path2 = rightTreeView.SelectedNode.Name;

                foreach (ListViewItem entry in leftFileView.SelectedItems)
                {
                    selectedFilesList.Add(entry.Text);
                }
                leftFileHandler.MoveListOfFiles(selectedFilesList, path1, path2);

                if (leftTreeView.SelectedNode != null)
                {
                    UpdateLeftFileView(leftTreeView.SelectedNode.Name);
                }
                if (rightTreeView.SelectedNode != null)
                {
                    UpdateRightFileView(rightTreeView.SelectedNode.Name);
                }
            }
            else
            {
                prov = false;
            }
            if (!prov)
            {
                string message = "Move failed!";
                string caption = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (leftFileView.SelectedItems.Count != 1 || leftTreeView.SelectedNode == null)
            {
                string message = "Chose one file to clear!";
                string caption = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string path = leftTreeView.SelectedNode.Name;

                if (path[path.Length - 1] != 92) path = path + Convert.ToChar(92);

                string name = leftFileView.SelectedItems[0].Text;
                string message1 = "Are you sure you want to clear the file " + name + "?";
                string caption1 = "Alert";
                MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;

                if (MessageBox.Show(message1, caption1, buttons1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (File.Exists(path+name))
                    {
                        File.Delete(path+name);
                        File.Create(path + name);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (leftFileView.SelectedItems.Count != 1 || leftTreeView.SelectedNode == null)
            {
                string message = "Chose one file to clear!";
                string caption = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string path = leftTreeView.SelectedNode.Name;

                if (path[path.Length - 1] != 92) path = path + Convert.ToChar(92);

                string name = leftFileView.SelectedItems[0].Text;
                
                if (File.Exists(path+name))
                {
                    TextEditor newTextEditor = new TextEditor(path, name);
                    newTextEditor.Show();

                    if (leftTreeView.SelectedNode != null)
                    {
                        UpdateLeftFileView(leftTreeView.SelectedNode.Name);
                    }
                    if (rightTreeView.SelectedNode != null)
                    {
                        UpdateRightFileView(rightTreeView.SelectedNode.Name);
                    }
                }
                else
                {
                    string message = "This file does not exist!";
                    string caption = "Alert";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Unsaved data will be lost. Are you sure you want to exit?";
            string caption = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (MessageBox.Show(message, caption, buttons) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Search newSearch = new Search(this, leftTreeView.SelectedNode.Name);
            newSearch.Show();
        }

        public void SelectFiles (List <string> filesToSelect)
        {
            leftFileView.SelectedItems.Clear();
            for (int i = 0; i<leftFileView.Items.Count; i++)
            {
                if (filesToSelect.Contains(leftFileView.Items[i].Text))
                {
                    leftFileView.Items[i].Selected = true;
                }
            }
        }

    }
}
/*
            string message = "treeView_AfterSelect!";
            string caption = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            */