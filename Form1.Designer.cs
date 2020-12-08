namespace Lab3_30
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftTreeView = new System.Windows.Forms.TreeView();
            this.leftDiskBox = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.leftFileView = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.leftFileTypeBox = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.rightFileTypeBox = new System.Windows.Forms.ComboBox();
            this.rightFileView = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rightDiskBox = new System.Windows.Forms.ComboBox();
            this.rightTreeView = new System.Windows.Forms.TreeView();
            this.debugTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftTreeView
            // 
            this.leftTreeView.Font = new System.Drawing.Font("Lobster", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftTreeView.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.leftTreeView.Location = new System.Drawing.Point(25, 24);
            this.leftTreeView.Name = "leftTreeView";
            this.leftTreeView.Size = new System.Drawing.Size(212, 421);
            this.leftTreeView.TabIndex = 0;
            this.leftTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.leftTreeView_BeforeExpand);
            this.leftTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // leftDiskBox
            // 
            this.leftDiskBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leftDiskBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leftDiskBox.Font = new System.Drawing.Font("Lobster", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftDiskBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.leftDiskBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.leftDiskBox.Location = new System.Drawing.Point(95, 451);
            this.leftDiskBox.Name = "leftDiskBox";
            this.leftDiskBox.Size = new System.Drawing.Size(142, 32);
            this.leftDiskBox.TabIndex = 3;
            this.leftDiskBox.SelectedIndexChanged += new System.EventHandler(this.leftDiskBox_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.ImageLocation = "C:\\lab3\\disk_icon.png";
            this.pictureBox3.Location = new System.Drawing.Point(25, 453);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Lobster", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Location = new System.Drawing.Point(25, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(271, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Move >>";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(154, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // leftFileView
            // 
            this.leftFileView.Font = new System.Drawing.Font("Lobster", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftFileView.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.leftFileView.HideSelection = false;
            this.leftFileView.Location = new System.Drawing.Point(243, 24);
            this.leftFileView.Name = "leftFileView";
            this.leftFileView.Size = new System.Drawing.Size(248, 421);
            this.leftFileView.TabIndex = 9;
            this.leftFileView.UseCompatibleStateImageBehavior = false;
            this.leftFileView.View = System.Windows.Forms.View.List;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Lobster", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox2.Location = new System.Drawing.Point(435, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manipulation";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Goldenrod;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(394, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 34);
            this.button7.TabIndex = 6;
            this.button7.Text = "Info";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Goldenrod;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(279, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Goldenrod;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(164, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Goldenrod;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(50, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // leftFileTypeBox
            // 
            this.leftFileTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leftFileTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leftFileTypeBox.Font = new System.Drawing.Font("Lobster", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftFileTypeBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.leftFileTypeBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.leftFileTypeBox.Location = new System.Drawing.Point(285, 451);
            this.leftFileTypeBox.Name = "leftFileTypeBox";
            this.leftFileTypeBox.Size = new System.Drawing.Size(206, 32);
            this.leftFileTypeBox.TabIndex = 10;
            this.leftFileTypeBox.SelectedIndexChanged += new System.EventHandler(this.leftFileTypeBox_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.ImageLocation = "C:\\lab3\\file_icon.png";
            this.pictureBox5.Location = new System.Drawing.Point(243, 451);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.ImageLocation = "C:\\lab3\\file_icon.png";
            this.pictureBox6.Location = new System.Drawing.Point(736, 451);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // rightFileTypeBox
            // 
            this.rightFileTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rightFileTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightFileTypeBox.Font = new System.Drawing.Font("Lobster", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightFileTypeBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.rightFileTypeBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.rightFileTypeBox.Location = new System.Drawing.Point(778, 451);
            this.rightFileTypeBox.Name = "rightFileTypeBox";
            this.rightFileTypeBox.Size = new System.Drawing.Size(206, 32);
            this.rightFileTypeBox.TabIndex = 14;
            this.rightFileTypeBox.SelectedIndexChanged += new System.EventHandler(this.rightFileTypeBox_SelectedIndexChanged);
            // 
            // rightFileView
            // 
            this.rightFileView.Font = new System.Drawing.Font("Lobster", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightFileView.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rightFileView.HideSelection = false;
            this.rightFileView.Location = new System.Drawing.Point(736, 24);
            this.rightFileView.Name = "rightFileView";
            this.rightFileView.Size = new System.Drawing.Size(248, 421);
            this.rightFileView.TabIndex = 13;
            this.rightFileView.UseCompatibleStateImageBehavior = false;
            this.rightFileView.View = System.Windows.Forms.View.List;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ImageLocation = "C:\\lab3\\disk_icon.png";
            this.pictureBox1.Location = new System.Drawing.Point(518, 453);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // rightDiskBox
            // 
            this.rightDiskBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rightDiskBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightDiskBox.Font = new System.Drawing.Font("Lobster", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightDiskBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.rightDiskBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.rightDiskBox.Location = new System.Drawing.Point(588, 451);
            this.rightDiskBox.Name = "rightDiskBox";
            this.rightDiskBox.Size = new System.Drawing.Size(142, 32);
            this.rightDiskBox.TabIndex = 17;
            this.rightDiskBox.SelectedIndexChanged += new System.EventHandler(this.rightDiskBox_SelectedIndexChanged);
            // 
            // rightTreeView
            // 
            this.rightTreeView.Font = new System.Drawing.Font("Lobster", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightTreeView.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rightTreeView.Location = new System.Drawing.Point(518, 24);
            this.rightTreeView.Name = "rightTreeView";
            this.rightTreeView.Size = new System.Drawing.Size(212, 421);
            this.rightTreeView.TabIndex = 16;
            this.rightTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.rightTreeView_BeforeExpand);
            this.rightTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rightTreeView_AfterSelect);
            // 
            // debugTextBox
            // 
            this.debugTextBox.Location = new System.Drawing.Point(1008, 24);
            this.debugTextBox.Multiline = true;
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(307, 550);
            this.debugTextBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab3_30.Properties.Resources.orange_abstract_gold_background_yellow_color_orange_gradient_abstract_background_orange_background_1258_13767__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 599);
            this.Controls.Add(this.debugTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rightDiskBox);
            this.Controls.Add(this.rightTreeView);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.rightFileTypeBox);
            this.Controls.Add(this.rightFileView);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.leftFileTypeBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.leftFileView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.leftDiskBox);
            this.Controls.Add(this.leftTreeView);
            this.Name = "Form1";
            this.Text = "File manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView leftTreeView;
        private System.Windows.Forms.ComboBox leftDiskBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView leftFileView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox leftFileTypeBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox rightFileTypeBox;
        private System.Windows.Forms.ListView rightFileView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox rightDiskBox;
        private System.Windows.Forms.TreeView rightTreeView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox debugTextBox;
        private System.Windows.Forms.Button button7;
    }
}

