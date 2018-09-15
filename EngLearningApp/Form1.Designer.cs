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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbSelectTextFilePath = new System.Windows.Forms.TextBox();
            this.btSelectTextFilePath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btReadTextFile = new System.Windows.Forms.Button();
            this.panelFileReader = new System.Windows.Forms.Panel();
            this.panelQuestioner = new System.Windows.Forms.Panel();
            this.btSaveWordsToDatabase = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbWordsCount = new System.Windows.Forms.Label();
            this.lbEnglishWord = new System.Windows.Forms.Label();
            this.pLeftButtonPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btl_Settings = new System.Windows.Forms.Button();
            this.btl_OldWords = new System.Windows.Forms.Button();
            this.btl_NewWords = new System.Windows.Forms.Button();
            this.btl_open = new System.Windows.Forms.Button();
            this.pLogPanel = new System.Windows.Forms.Panel();
            this.pTopPanel = new System.Windows.Forms.Panel();
            this.btt_Minimalize = new System.Windows.Forms.Button();
            this.btt_close = new System.Windows.Forms.Button();
            this.panelFileReader.SuspendLayout();
            this.panelQuestioner.SuspendLayout();
            this.pLeftButtonPanel.SuspendLayout();
            this.pTopPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.tbSelectTextFilePath.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSelectTextFilePath.Location = new System.Drawing.Point(50, 79);
            this.tbSelectTextFilePath.Name = "tbSelectTextFilePath";
            this.tbSelectTextFilePath.Size = new System.Drawing.Size(570, 22);
            this.tbSelectTextFilePath.TabIndex = 2;
            // 
            // btSelectTextFilePath
            // 
            this.btSelectTextFilePath.Location = new System.Drawing.Point(435, 112);
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
            this.btReadTextFile.Location = new System.Drawing.Point(528, 112);
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
            this.panelQuestioner.Controls.Add(this.btSaveWordsToDatabase);
            this.panelQuestioner.Controls.Add(this.button4);
            this.panelQuestioner.Controls.Add(this.button3);
            this.panelQuestioner.Controls.Add(this.button1);
            this.panelQuestioner.Controls.Add(this.lbWordsCount);
            this.panelQuestioner.Controls.Add(this.lbEnglishWord);
            this.panelQuestioner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestioner.Location = new System.Drawing.Point(188, 34);
            this.panelQuestioner.Name = "panelQuestioner";
            this.panelQuestioner.Size = new System.Drawing.Size(667, 382);
            this.panelQuestioner.TabIndex = 6;
            this.panelQuestioner.Visible = false;
            // 
            // btSaveWordsToDatabase
            // 
            this.btSaveWordsToDatabase.FlatAppearance.BorderSize = 0;
            this.btSaveWordsToDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveWordsToDatabase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSaveWordsToDatabase.ForeColor = System.Drawing.Color.White;
            this.btSaveWordsToDatabase.Image = global::EngLearningApp.Properties.Resources.save;
            this.btSaveWordsToDatabase.Location = new System.Drawing.Point(528, 301);
            this.btSaveWordsToDatabase.Name = "btSaveWordsToDatabase";
            this.btSaveWordsToDatabase.Size = new System.Drawing.Size(127, 69);
            this.btSaveWordsToDatabase.TabIndex = 8;
            this.btSaveWordsToDatabase.Text = "Save";
            this.btSaveWordsToDatabase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSaveWordsToDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSaveWordsToDatabase.UseVisualStyleBackColor = true;
            this.btSaveWordsToDatabase.Click += new System.EventHandler(this.btSaveWordsToDatabase_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(373, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "New word";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btRed_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(270, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Don\'t know Really";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btYellow_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(167, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Know";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btGreen_Click);
            // 
            // lbWordsCount
            // 
            this.lbWordsCount.AutoSize = true;
            this.lbWordsCount.Location = new System.Drawing.Point(6, 349);
            this.lbWordsCount.Name = "lbWordsCount";
            this.lbWordsCount.Size = new System.Drawing.Size(116, 21);
            this.lbWordsCount.TabIndex = 4;
            this.lbWordsCount.Text = "Word number";
            // 
            // lbEnglishWord
            // 
            this.lbEnglishWord.AutoSize = true;
            this.lbEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEnglishWord.Location = new System.Drawing.Point(162, 147);
            this.lbEnglishWord.Name = "lbEnglishWord";
            this.lbEnglishWord.Size = new System.Drawing.Size(81, 25);
            this.lbEnglishWord.TabIndex = 0;
            this.lbEnglishWord.Text = "english";
            // 
            // pLeftButtonPanel
            // 
            this.pLeftButtonPanel.Controls.Add(this.button2);
            this.pLeftButtonPanel.Controls.Add(this.btl_Settings);
            this.pLeftButtonPanel.Controls.Add(this.btl_OldWords);
            this.pLeftButtonPanel.Controls.Add(this.btl_NewWords);
            this.pLeftButtonPanel.Controls.Add(this.btl_open);
            this.pLeftButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftButtonPanel.Location = new System.Drawing.Point(0, 34);
            this.pLeftButtonPanel.Name = "pLeftButtonPanel";
            this.pLeftButtonPanel.Size = new System.Drawing.Size(188, 482);
            this.pLeftButtonPanel.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::EngLearningApp.Properties.Resources._new;
            this.button2.Location = new System.Drawing.Point(3, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 88);
            this.button2.TabIndex = 4;
            this.button2.Text = "New words";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btl_Settings
            // 
            this.btl_Settings.FlatAppearance.BorderSize = 0;
            this.btl_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btl_Settings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btl_Settings.ForeColor = System.Drawing.Color.White;
            this.btl_Settings.Image = ((System.Drawing.Image)(resources.GetObject("btl_Settings.Image")));
            this.btl_Settings.Location = new System.Drawing.Point(3, 382);
            this.btl_Settings.Name = "btl_Settings";
            this.btl_Settings.Size = new System.Drawing.Size(188, 88);
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
            this.btl_OldWords.Image = global::EngLearningApp.Properties.Resources.old;
            this.btl_OldWords.Location = new System.Drawing.Point(3, 288);
            this.btl_OldWords.Name = "btl_OldWords";
            this.btl_OldWords.Size = new System.Drawing.Size(188, 88);
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
            this.btl_NewWords.Image = global::EngLearningApp.Properties.Resources.questioner;
            this.btl_NewWords.Location = new System.Drawing.Point(3, 100);
            this.btl_NewWords.Name = "btl_NewWords";
            this.btl_NewWords.Size = new System.Drawing.Size(188, 88);
            this.btl_NewWords.TabIndex = 1;
            this.btl_NewWords.Text = "Question words";
            this.btl_NewWords.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btl_NewWords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btl_NewWords.UseVisualStyleBackColor = true;
            this.btl_NewWords.Click += new System.EventHandler(this.btl_NewWords_Click);
            // 
            // btl_open
            // 
            this.btl_open.FlatAppearance.BorderSize = 0;
            this.btl_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btl_open.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btl_open.ForeColor = System.Drawing.Color.White;
            this.btl_open.Image = global::EngLearningApp.Properties.Resources.open;
            this.btl_open.Location = new System.Drawing.Point(3, 6);
            this.btl_open.Name = "btl_open";
            this.btl_open.Size = new System.Drawing.Size(188, 88);
            this.btl_open.TabIndex = 0;
            this.btl_open.Text = "Open";
            this.btl_open.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btl_open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btl_open.UseVisualStyleBackColor = true;
            this.btl_open.Click += new System.EventHandler(this.btl_open_Click);
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
            this.pTopPanel.Controls.Add(this.btt_Minimalize);
            this.pTopPanel.Controls.Add(this.btt_close);
            this.pTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pTopPanel.Name = "pTopPanel";
            this.pTopPanel.Size = new System.Drawing.Size(855, 34);
            this.pTopPanel.TabIndex = 9;
            this.pTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTopPane_MouseDown);
            this.pTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTopPane_MouseMove);
            this.pTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pTopPane_MouseUp);
            // 
            // btt_Minimalize
            // 
            this.btt_Minimalize.FlatAppearance.BorderSize = 0;
            this.btt_Minimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_Minimalize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btt_Minimalize.ForeColor = System.Drawing.Color.White;
            this.btt_Minimalize.Image = global::EngLearningApp.Properties.Resources.minimize;
            this.btt_Minimalize.Location = new System.Drawing.Point(791, 0);
            this.btt_Minimalize.Name = "btt_Minimalize";
            this.btt_Minimalize.Size = new System.Drawing.Size(29, 31);
            this.btt_Minimalize.TabIndex = 10;
            this.btt_Minimalize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btt_Minimalize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btt_Minimalize.UseVisualStyleBackColor = true;
            this.btt_Minimalize.Click += new System.EventHandler(this.btt_Minimalize_Click);
            // 
            // btt_close
            // 
            this.btt_close.FlatAppearance.BorderSize = 0;
            this.btt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btt_close.ForeColor = System.Drawing.Color.White;
            this.btt_close.Image = global::EngLearningApp.Properties.Resources.cancel;
            this.btt_close.Location = new System.Drawing.Point(826, 0);
            this.btt_close.Name = "btt_close";
            this.btt_close.Size = new System.Drawing.Size(29, 31);
            this.btt_close.TabIndex = 9;
            this.btt_close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btt_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btt_close.UseVisualStyleBackColor = true;
            this.btt_close.Click += new System.EventHandler(this.btt_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.panelQuestioner);
            this.Controls.Add(this.panelFileReader);
            this.Controls.Add(this.pLogPanel);
            this.Controls.Add(this.pLeftButtonPanel);
            this.Controls.Add(this.pTopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Tag = "git";
            this.Text = "English Word App";
            this.panelFileReader.ResumeLayout(false);
            this.panelFileReader.PerformLayout();
            this.panelQuestioner.ResumeLayout(false);
            this.panelQuestioner.PerformLayout();
            this.pLeftButtonPanel.ResumeLayout(false);
            this.pTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSelectTextFilePath;
        private System.Windows.Forms.Button btSelectTextFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btReadTextFile;
        private System.Windows.Forms.Panel panelFileReader;
        private System.Windows.Forms.Panel panelQuestioner;
        private System.Windows.Forms.Label lbEnglishWord;
        private System.Windows.Forms.Label lbWordsCount;
        private System.Windows.Forms.Panel pLeftButtonPanel;
        private System.Windows.Forms.Button btl_open;
        private System.Windows.Forms.Panel pLogPanel;
        private System.Windows.Forms.Panel pTopPanel;
        private System.Windows.Forms.Button btl_Settings;
        private System.Windows.Forms.Button btl_OldWords;
        private System.Windows.Forms.Button btl_NewWords;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSaveWordsToDatabase;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btt_close;
        private System.Windows.Forms.Button btt_Minimalize;
    }
}

