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
    public partial class TextEditor : Form
    {
        string curPath = "";
        string curName = "";
        public TextEditor(string path, string name)
        {
            InitializeComponent();
            curName = name;
            curPath = path;
            InitWorkspace();
        }

        private void InitWorkspace ()
        {
            textBox2.Text = curName;
            string text = File.ReadAllText(curPath + curName);
            textBox1.Text = text;
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char tab = '\t';
            string newtext = "";
            int curLineSymbCount = 0;
            string curLine = "";
            for (int i = 0; i<text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    if (curLineSymbCount > 0)
                        newtext = newtext + text[i];
                    curLineSymbCount = 0;
                    curLine = "";
                }
                else
                {
                    if (i!=0 && (text[i] == ' ' || text[i] == tab))
                    {
                        if (text[i-1] != ' ' && text[i-1] != tab)
                        {
                            newtext = newtext + text[i];
                        }
                    }
                    else
                    {
                        newtext = newtext + text[i];
                        if (text[i] != Convert.ToChar('\r')) curLineSymbCount++;
                        curLine = curLine + text[i];
                    }
                }
            }
            textBox1.Text = newtext;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string kek1 = "";
            for (int i = 0; i<text.Length; i++)
            {
                if (text[i] != Convert.ToChar('\r')) kek1 = kek1 + text[i];
            }
            text = kek1;
            string[] lines = text.Split('\n');
            if (lines.Length > 0)
            {
                string newtext = lines[0];

                for (int i = 1; i < lines.Length; i++)
                {
                    if (lines[i] != lines[i - 1])
                    {
                        newtext = newtext + lines[i] + "\n";
                    }
                }
                text = newtext;
            }

            string[] kek = curName.Split('.');
            string name = kek[0] + "_copy";
            string extencion = '.' + kek[1];
            if (File.Exists(curPath + name + extencion))
            {
                int i = 1;
                while (File.Exists(curPath + name + '(' + i.ToString() + ')' + extencion))
                {
                    i++;
                }
                name = name + '(' + i.ToString() + ')';
            }
            File.WriteAllText(curPath + name + extencion, text);
        }
        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Unsaved data will be lost. Are you sure you want to exit?";
            string caption = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (MessageBox.Show(message, caption, buttons) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            if (name != curName && File.Exists(curPath+name))
            {
                string message = "File with the same name already exists. Overwrite the file??";
                string caption = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                if (MessageBox.Show(message, caption, buttons) == System.Windows.Forms.DialogResult.No)
                {
                    return;
}
            }
            string text = textBox1.Text;
            string kek1 = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != Convert.ToChar('\r')) kek1 = kek1 + text[i];
            }
            text = kek1;
            if (File.Exists(curPath + name)) File.Delete(curPath + name);
            File.WriteAllText(curPath + name, text);
        }
    }
}
