namespace EngLearningApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSelectTextFilePath = new System.Windows.Forms.TextBox();
            this.btSelectTextFilePath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbReadTextFile = new System.Windows.Forms.Button();
            this.panelFileReader = new System.Windows.Forms.Panel();
            this.panelQuestioner = new System.Windows.Forms.Panel();
            this.lbWordsCount = new System.Windows.Forms.Label();
            this.btSaveWordsToDatabase = new System.Windows.Forms.Button();
            this.btRed = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btYellow = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btGreen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEnglishWord = new System.Windows.Forms.Label();
            this.panelFileReader.SuspendLayout();
            this.panelQuestioner.SuspendLayout();
            this.btRed.SuspendLayout();
            this.btYellow.SuspendLayout();
            this.btGreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btStartQuestioner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forrás:";
            // 
            // tbSelectTextFilePath
            // 
            this.tbSelectTextFilePath.Location = new System.Drawing.Point(54, 17);
            this.tbSelectTextFilePath.Name = "tbSelectTextFilePath";
            this.tbSelectTextFilePath.Size = new System.Drawing.Size(653, 20);
            this.tbSelectTextFilePath.TabIndex = 2;
            // 
            // btSelectTextFilePath
            // 
            this.btSelectTextFilePath.Location = new System.Drawing.Point(722, 14);
            this.btSelectTextFilePath.Name = "btSelectTextFilePath";
            this.btSelectTextFilePath.Size = new System.Drawing.Size(75, 23);
            this.btSelectTextFilePath.TabIndex = 3;
            this.btSelectTextFilePath.Text = "Tallózás";
            this.btSelectTextFilePath.UseVisualStyleBackColor = true;
            this.btSelectTextFilePath.Click += new System.EventHandler(this.btSelectTextFilePath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbReadTextFile
            // 
            this.tbReadTextFile.Location = new System.Drawing.Point(314, 44);
            this.tbReadTextFile.Name = "tbReadTextFile";
            this.tbReadTextFile.Size = new System.Drawing.Size(75, 23);
            this.tbReadTextFile.TabIndex = 4;
            this.tbReadTextFile.Text = "Beolvasás";
            this.tbReadTextFile.UseVisualStyleBackColor = true;
            this.tbReadTextFile.Click += new System.EventHandler(this.btReadTextFile_Click);
            // 
            // panelFileReader
            // 
            this.panelFileReader.Controls.Add(this.label1);
            this.panelFileReader.Controls.Add(this.button1);
            this.panelFileReader.Controls.Add(this.tbReadTextFile);
            this.panelFileReader.Controls.Add(this.tbSelectTextFilePath);
            this.panelFileReader.Controls.Add(this.btSelectTextFilePath);
            this.panelFileReader.Location = new System.Drawing.Point(3, 60);
            this.panelFileReader.Name = "panelFileReader";
            this.panelFileReader.Size = new System.Drawing.Size(794, 100);
            this.panelFileReader.TabIndex = 5;
            // 
            // panelQuestioner
            // 
            this.panelQuestioner.Controls.Add(this.lbWordsCount);
            this.panelQuestioner.Controls.Add(this.btSaveWordsToDatabase);
            this.panelQuestioner.Controls.Add(this.btRed);
            this.panelQuestioner.Controls.Add(this.btYellow);
            this.panelQuestioner.Controls.Add(this.btGreen);
            this.panelQuestioner.Controls.Add(this.lbEnglishWord);
            this.panelQuestioner.Location = new System.Drawing.Point(6, 50);
            this.panelQuestioner.Name = "panelQuestioner";
            this.panelQuestioner.Size = new System.Drawing.Size(788, 334);
            this.panelQuestioner.TabIndex = 6;
            this.panelQuestioner.Visible = false;
            // 
            // lbWordsCount
            // 
            this.lbWordsCount.AutoSize = true;
            this.lbWordsCount.Location = new System.Drawing.Point(4, 10);
            this.lbWordsCount.Name = "lbWordsCount";
            this.lbWordsCount.Size = new System.Drawing.Size(35, 13);
            this.lbWordsCount.TabIndex = 4;
            this.lbWordsCount.Text = "label5";
            // 
            // btSaveWordsToDatabase
            // 
            this.btSaveWordsToDatabase.Location = new System.Drawing.Point(599, 249);
            this.btSaveWordsToDatabase.Name = "btSaveWordsToDatabase";
            this.btSaveWordsToDatabase.Size = new System.Drawing.Size(75, 23);
            this.btSaveWordsToDatabase.TabIndex = 3;
            this.btSaveWordsToDatabase.Text = "Mentés";
            this.btSaveWordsToDatabase.UseVisualStyleBackColor = true;
            this.btSaveWordsToDatabase.Click += new System.EventHandler(this.btSaveWordsToDatabase_Click);
            // 
            // btRed
            // 
            this.btRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btRed.Controls.Add(this.label4);
            this.btRed.Location = new System.Drawing.Point(425, 116);
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(97, 35);
            this.btRed.TabIndex = 2;
            this.btRed.Click += new System.EventHandler(this.btRed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Új szó";
            // 
            // btYellow
            // 
            this.btYellow.BackColor = System.Drawing.Color.Yellow;
            this.btYellow.Controls.Add(this.label3);
            this.btYellow.Location = new System.Drawing.Point(322, 116);
            this.btYellow.Name = "btYellow";
            this.btYellow.Size = new System.Drawing.Size(97, 35);
            this.btYellow.TabIndex = 2;
            this.btYellow.Click += new System.EventHandler(this.btYellow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gyakoroljuk";
            // 
            // btGreen
            // 
            this.btGreen.BackColor = System.Drawing.Color.Lime;
            this.btGreen.Controls.Add(this.label2);
            this.btGreen.Location = new System.Drawing.Point(219, 116);
            this.btGreen.Name = "btGreen";
            this.btGreen.Size = new System.Drawing.Size(97, 35);
            this.btGreen.TabIndex = 1;
            this.btGreen.Click += new System.EventHandler(this.btGreen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tudom";
            // 
            // lbEnglishWord
            // 
            this.lbEnglishWord.AutoSize = true;
            this.lbEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEnglishWord.Location = new System.Drawing.Point(214, 72);
            this.lbEnglishWord.Name = "lbEnglishWord";
            this.lbEnglishWord.Size = new System.Drawing.Size(70, 25);
            this.lbEnglishWord.TabIndex = 0;
            this.lbEnglishWord.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFileReader);
            this.Controls.Add(this.panelQuestioner);
            this.Name = "Form1";
            this.Tag = "git";
            this.Text = "English Word App";
            this.panelFileReader.ResumeLayout(false);
            this.panelFileReader.PerformLayout();
            this.panelQuestioner.ResumeLayout(false);
            this.panelQuestioner.PerformLayout();
            this.btRed.ResumeLayout(false);
            this.btRed.PerformLayout();
            this.btYellow.ResumeLayout(false);
            this.btYellow.PerformLayout();
            this.btGreen.ResumeLayout(false);
            this.btGreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSelectTextFilePath;
        private System.Windows.Forms.Button btSelectTextFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button tbReadTextFile;
        private System.Windows.Forms.Panel panelFileReader;
        private System.Windows.Forms.Panel panelQuestioner;
        private System.Windows.Forms.Panel btRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel btYellow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel btGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEnglishWord;
        private System.Windows.Forms.Label lbWordsCount;
        private System.Windows.Forms.Button btSaveWordsToDatabase;
    }
}

