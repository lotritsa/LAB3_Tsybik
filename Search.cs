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
    public partial class Search : Form
    {
        Form1 num;
        string path = "";
        public Search(Form1 kek, string path1)
        {
            InitializeComponent();
            num = kek;
            path = path1;

            if (path[path.Length - 1] != 92) path = path + Convert.ToChar(92);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            string[] words = text.Split(',');
            List<string> filesToSelect = new List<string>();
            string extencion = "";
            List<string> wordsLookedFor = new List<string>();
            List<string> tagsLookedFor = new List<string>();
            for (int i = 0; i<words.Length; i++)
            {
                string newWord = "";
                for (int j = 0; j<words[i].Length; j++)
                {
                    if (words[i][j] != ' ') newWord = newWord + words[i][j];
                }
                words[i] = newWord;
                if (words[i][0] == '*')
                {
                    if (extencion != "")
                    {

                        string message = "Please enter only one valid extension!";
                        string caption = "Alert";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                        return;
                    }
                    else extencion = words[i].Substring(1);
                } else
                {
                    if (words[i][0] == '<') tagsLookedFor.Add(words[i].Substring(1,words[i].Length-2));
                    else wordsLookedFor.Add(words[i]);
                }
            }
            List<string> allFiles = num.leftFileViewerShowed.filesList;

            foreach (string entry in allFiles)
            {
                string[] srlk = entry.Split('.');
                if (extencion == "" || srlk[1] == extencion)
                {
                    if (File.Exists(path+entry))
                    {
                        string entryText = File.ReadAllText(path + entry);
                        string[] entryWords = entryText.Split(' ');
                        string[] entryTags = entryText.Split('<', '>');
                        bool prov = true;
                        foreach (string s in wordsLookedFor)
                        {
                            if (!entryWords.Contains(s)) prov = false;
                        }
                        foreach (string s in tagsLookedFor)
                        {
                            if (!entryTags.Contains(s)) prov = false;
                        }
                        if (prov) filesToSelect.Add(entry);
                    }
                }
            }

            num.SelectFiles(filesToSelect);
        }
    }
}
