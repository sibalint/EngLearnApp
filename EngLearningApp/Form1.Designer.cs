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
            this.btReadTextFile = new System.Windows.Forms.Button();
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
            this.pLeftButtonPanel = new System.Windows.Forms.Panel();
            this.pLogPanel = new System.Windows.Forms.Panel();
            this.pTopPanel = new System.Windows.Forms.Panel();
            this.btl_Settings = new System.Windows.Forms.Button();
            this.btl_OldWords = new System.Windows.Forms.Button();
            this.btl_NewWords = new System.Windows.Forms.Button();
            this.btl_open = new System.Windows.Forms.Button();
            this.panelFileReader.SuspendLayout();
            this.panelQuestioner.SuspendLayout();
            this.btRed.SuspendLayout();
            this.btYellow.SuspendLayout();
            this.btGreen.SuspendLayout();
            this.pLeftButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btStartQuestioner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fájl helye:";
            // 
            // tbSelectTextFilePath
            // 
            this.tbSelectTextFilePath.Location = new System.Drawing.Point(50, 79);
            this.tbSelectTextFilePath.Name = "tbSelectTextFilePath";
            this.tbSelectTextFilePath.Size = new System.Drawing.Size(570, 27);
            this.tbSelectTextFilePath.TabIndex = 2;
            // 
            // btSelectTextFilePath
            // 
            this.btSelectTextFilePath.Location = new System.Drawing.Point(344, 112);
            this.btSelectTextFilePath.Name = "btSelectTextFilePath";
            this.btSelectTextFilePath.Size = new System.Drawing.Size(87, 29);
            this.btSelectTextFilePath.TabIndex = 3;
            this.btSelectTextFilePath.Text = "Tallózás";
            this.btSelectTextFilePath.UseVisualStyleBackColor = true;
            this.btSelectTextFilePath.Click += new System.EventHandler(this.btSelectTextFilePath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btReadTextFile
            // 
            this.btReadTextFile.Location = new System.Drawing.Point(437, 112);
            this.btReadTextFile.Name = "btReadTextFile";
            this.btReadTextFile.Size = new System.Drawing.Size(87, 29);
            this.btReadTextFile.TabIndex = 4;
            this.btReadTextFile.Text = "Beolvasás";
            this.btReadTextFile.UseVisualStyleBackColor = true;
            this.btReadTextFile.Click += new System.EventHandler(this.btReadTextFile_Click);
            // 
            // panelFileReader
            // 
            this.panelFileReader.Controls.Add(this.label1);
            this.panelFileReader.Controls.Add(this.button1);
            this.panelFileReader.Controls.Add(this.btReadTextFile);
            this.panelFileReader.Controls.Add(this.tbSelectTextFilePath);
            this.panelFileReader.Controls.Add(this.btSelectTextFilePath);
            this.panelFileReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFileReader.Location = new System.Drawing.Point(188, 34);
            this.panelFileReader.Name = "panelFileReader";
            this.panelFileReader.Size = new System.Drawing.Size(667, 382);
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
            this.panelQuestioner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestioner.Location = new System.Drawing.Point(188, 34);
            this.panelQuestioner.Name = "panelQuestioner";
            this.panelQuestioner.Size = new System.Drawing.Size(667, 382);
            this.panelQuestioner.TabIndex = 6;
            this.panelQuestioner.Visible = false;
            // 
            // lbWordsCount
            // 
            this.lbWordsCount.AutoSize = true;
            this.lbWordsCount.Location = new System.Drawing.Point(4, 10);
            this.lbWordsCount.Name = "lbWordsCount";
            this.lbWordsCount.Size = new System.Drawing.Size(57, 21);
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
            this.label4.Size = new System.Drawing.Size(51, 21);
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
            this.label3.Size = new System.Drawing.Size(100, 21);
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
            this.label2.Size = new System.Drawing.Size(64, 21);
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
            // pLeftButtonPanel
            // 
            this.pLeftButtonPanel.Controls.Add(this.btl_Settings);
            this.pLeftButtonPanel.Controls.Add(this.btl_OldWords);
            this.pLeftButtonPanel.Controls.Add(this.btl_NewWords);
            this.pLeftButtonPanel.Controls.Add(this.btl_open);
            this.pLeftButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.pLeftButtonPanel.Name = "pLeftButtonPanel";
            this.pLeftButtonPanel.Size = new System.Drawing.Size(188, 516);
            this.pLeftButtonPanel.TabIndex = 7;
            // 
            // pLogPanel
            // 
            this.pLogPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pLogPanel.Location = new System.Drawing.Point(188, 416);
            this.pLogPanel.Name = "pLogPanel";
            this.pLogPanel.Size = new System.Drawing.Size(667, 100);
            this.pLogPanel.TabIndex = 8;
            // 
            // pTopPanel
            // 
            this.pTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTopPanel.Location = new System.Drawing.Point(188, 0);
            this.pTopPanel.Name = "pTopPanel";
            this.pTopPanel.Size = new System.Drawing.Size(667, 34);
            this.pTopPanel.TabIndex = 9;
            // 
            // btl_Settings
            // 
            this.btl_Settings.FlatAppearance.BorderSize = 0;
            this.btl_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btl_Settings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btl_Settings.ForeColor = System.Drawing.Color.White;
            this.btl_Settings.Location = new System.Drawing.Point(0, 377);
            this.btl_Settings.Name = "btl_Settings";
            this.btl_Settings.Size = new System.Drawing.Size(188, 97);
            this.btl_Settings.TabIndex = 3;
            this.btl_Settings.Text = "Settings";
            this.btl_Settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btl_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btl_Settings.UseVisualStyleBackColor = true;
            // 
            // btl_OldWords
            // 
            this.btl_OldWords.FlatAppearance.BorderSize = 0;
            this.btl_OldWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btl_OldWords.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btl_OldWords.ForeColor = System.Drawing.Color.White;
            this.btl_OldWords.Image = global::EngLearningApp.Properties.Resources.oldwords;
            this.btl_OldWords.Location = new System.Drawing.Point(0, 274);
            this.btl_OldWords.Name = "btl_OldWords";
            this.btl_OldWords.Size = new System.Drawing.Size(188, 97);
            this.btl_OldWords.TabIndex = 2;
            this.btl_OldWords.Text = "Old words";
            this.btl_OldWords.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btl_OldWords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btl_OldWords.UseVisualStyleBackColor = true;
            // 
            // btl_NewWords
            // 
            this.btl_NewWords.FlatAppearance.BorderSize = 0;
            this.btl_NewWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btl_NewWords.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btl_NewWords.ForeColor = System.Drawing.Color.White;
            this.btl_NewWords.Image = global::EngLearningApp.Properties.Resources.newwords;
            this.btl_NewWords.Location = new System.Drawing.Point(0, 171);
            this.btl_NewWords.Name = "btl_NewWords";
            this.btl_NewWords.Size = new System.Drawing.Size(188, 97);
            this.btl_NewWords.TabIndex = 1;
            this.btl_NewWords.Text = "New words";
            this.btl_NewWords.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btl_NewWords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btl_NewWords.UseVisualStyleBackColor = true;
            // 
            // btl_open
            // 
            this.btl_open.FlatAppearance.BorderSize = 0;
            this.btl_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btl_open.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btl_open.ForeColor = System.Drawing.Color.White;
            this.btl_open.Location = new System.Drawing.Point(0, 68);
            this.btl_open.Name = "btl_open";
            this.btl_open.Size = new System.Drawing.Size(188, 97);
            this.btl_open.TabIndex = 0;
            this.btl_open.Text = "Open";
            this.btl_open.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btl_open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btl_open.UseVisualStyleBackColor = true;
            this.btl_open.Click += new System.EventHandler(this.btl_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.panelFileReader);
            this.Controls.Add(this.panelQuestioner);
            this.Controls.Add(this.pTopPanel);
            this.Controls.Add(this.pLogPanel);
            this.Controls.Add(this.pLeftButtonPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.pLeftButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSelectTextFilePath;
        private System.Windows.Forms.Button btSelectTextFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btReadTextFile;
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
        private System.Windows.Forms.Panel pLeftButtonPanel;
        private System.Windows.Forms.Button btl_open;
        private System.Windows.Forms.Panel pLogPanel;
        private System.Windows.Forms.Panel pTopPanel;
        private System.Windows.Forms.Button btl_Settings;
        private System.Windows.Forms.Button btl_OldWords;
        private System.Windows.Forms.Button btl_NewWords;
    }
}

