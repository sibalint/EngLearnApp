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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelShowUnKnownList = new System.Windows.Forms.Panel();
            this.panelShowUnKnownListBottomPanel = new System.Windows.Forms.Panel();
            this.bt_NwB_KnowledgeChecking = new System.Windows.Forms.Button();
            this.bt_NwB_Copy = new System.Windows.Forms.Button();
            this.bt_NwB_openWeb = new System.Windows.Forms.Button();
            this.rtb_ShowWords = new System.Windows.Forms.RichTextBox();
            this.panelQuestioner = new System.Windows.Forms.Panel();
            this.tbEnglishWord = new System.Windows.Forms.TextBox();
            this.btSaveWordsToDatabase = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbWordsCount = new System.Windows.Forms.Label();
            this.pLeftButtonPanel = new System.Windows.Forms.Panel();
            this.btl_NewWords = new System.Windows.Forms.Button();
            this.btl_Settings = new System.Windows.Forms.Button();
            this.btl_OldWords = new System.Windows.Forms.Button();
            this.btl_Questioner = new System.Windows.Forms.Button();
            this.btl_open = new System.Windows.Forms.Button();
            this.pLogPanel = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.pTopPanel = new System.Windows.Forms.Panel();
            this.btt_Minimalize = new System.Windows.Forms.Button();
            this.btt_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_WelcomeRocket = new System.Windows.Forms.PictureBox();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.panelShowUnKnownList.SuspendLayout();
            this.panelShowUnKnownListBottomPanel.SuspendLayout();
            this.panelQuestioner.SuspendLayout();
            this.pLeftButtonPanel.SuspendLayout();
            this.pLogPanel.SuspendLayout();
            this.pTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WelcomeRocket)).BeginInit();
            this.panelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Select a text file";
            // 
            // panelShowUnKnownList
            // 
            this.panelShowUnKnownList.Controls.Add(this.panelShowUnKnownListBottomPanel);
            this.panelShowUnKnownList.Controls.Add(this.rtb_ShowWords);
            this.panelShowUnKnownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowUnKnownList.Location = new System.Drawing.Point(188, 34);
            this.panelShowUnKnownList.Name = "panelShowUnKnownList";
            this.panelShowUnKnownList.Size = new System.Drawing.Size(667, 455);
            this.panelShowUnKnownList.TabIndex = 5;
            this.panelShowUnKnownList.Visible = false;
            // 
            // panelShowUnKnownListBottomPanel
            // 
            this.panelShowUnKnownListBottomPanel.Controls.Add(this.bt_NwB_KnowledgeChecking);
            this.panelShowUnKnownListBottomPanel.Controls.Add(this.bt_NwB_Copy);
            this.panelShowUnKnownListBottomPanel.Controls.Add(this.bt_NwB_openWeb);
            this.panelShowUnKnownListBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShowUnKnownListBottomPanel.Location = new System.Drawing.Point(0, 428);
            this.panelShowUnKnownListBottomPanel.Name = "panelShowUnKnownListBottomPanel";
            this.panelShowUnKnownListBottomPanel.Size = new System.Drawing.Size(667, 27);
            this.panelShowUnKnownListBottomPanel.TabIndex = 9;
            // 
            // bt_NwB_KnowledgeChecking
            // 
            this.bt_NwB_KnowledgeChecking.FlatAppearance.BorderSize = 0;
            this.bt_NwB_KnowledgeChecking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NwB_KnowledgeChecking.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_NwB_KnowledgeChecking.ForeColor = System.Drawing.Color.White;
            this.bt_NwB_KnowledgeChecking.Location = new System.Drawing.Point(3, 3);
            this.bt_NwB_KnowledgeChecking.Name = "bt_NwB_KnowledgeChecking";
            this.bt_NwB_KnowledgeChecking.Size = new System.Drawing.Size(148, 24);
            this.bt_NwB_KnowledgeChecking.TabIndex = 4;
            this.bt_NwB_KnowledgeChecking.Text = "Knowledge checking";
            this.bt_NwB_KnowledgeChecking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_NwB_KnowledgeChecking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_NwB_KnowledgeChecking.UseVisualStyleBackColor = true;
            this.bt_NwB_KnowledgeChecking.Click += new System.EventHandler(this.bt_NwB_KnowledgeChecking_Click);
            // 
            // bt_NwB_Copy
            // 
            this.bt_NwB_Copy.FlatAppearance.BorderSize = 0;
            this.bt_NwB_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NwB_Copy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_NwB_Copy.ForeColor = System.Drawing.Color.White;
            this.bt_NwB_Copy.Location = new System.Drawing.Point(452, 0);
            this.bt_NwB_Copy.Name = "bt_NwB_Copy";
            this.bt_NwB_Copy.Size = new System.Drawing.Size(79, 24);
            this.bt_NwB_Copy.TabIndex = 3;
            this.bt_NwB_Copy.Text = "Copy";
            this.bt_NwB_Copy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_NwB_Copy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_NwB_Copy.UseVisualStyleBackColor = true;
            this.bt_NwB_Copy.Click += new System.EventHandler(this.bt_NwB_Copy_Click);
            // 
            // bt_NwB_openWeb
            // 
            this.bt_NwB_openWeb.FlatAppearance.BorderSize = 0;
            this.bt_NwB_openWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NwB_openWeb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_NwB_openWeb.ForeColor = System.Drawing.Color.White;
            this.bt_NwB_openWeb.Location = new System.Drawing.Point(537, 0);
            this.bt_NwB_openWeb.Name = "bt_NwB_openWeb";
            this.bt_NwB_openWeb.Size = new System.Drawing.Size(128, 24);
            this.bt_NwB_openWeb.TabIndex = 2;
            this.bt_NwB_openWeb.Text = "Open Google Translator";
            this.bt_NwB_openWeb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_NwB_openWeb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_NwB_openWeb.UseVisualStyleBackColor = true;
            this.bt_NwB_openWeb.Click += new System.EventHandler(this.bt_NwB_openWeb_Click);
            // 
            // rtb_ShowWords
            // 
            this.rtb_ShowWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.rtb_ShowWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_ShowWords.ForeColor = System.Drawing.Color.White;
            this.rtb_ShowWords.Location = new System.Drawing.Point(3, 7);
            this.rtb_ShowWords.Name = "rtb_ShowWords";
            this.rtb_ShowWords.Size = new System.Drawing.Size(661, 410);
            this.rtb_ShowWords.TabIndex = 0;
            this.rtb_ShowWords.Text = "";
            // 
            // panelQuestioner
            // 
            this.panelQuestioner.Controls.Add(this.tbEnglishWord);
            this.panelQuestioner.Controls.Add(this.btSaveWordsToDatabase);
            this.panelQuestioner.Controls.Add(this.button4);
            this.panelQuestioner.Controls.Add(this.button3);
            this.panelQuestioner.Controls.Add(this.button1);
            this.panelQuestioner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestioner.Location = new System.Drawing.Point(188, 34);
            this.panelQuestioner.Name = "panelQuestioner";
            this.panelQuestioner.Size = new System.Drawing.Size(667, 455);
            this.panelQuestioner.TabIndex = 6;
            this.panelQuestioner.Visible = false;
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tbEnglishWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.tbEnglishWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.tbEnglishWord.Location = new System.Drawing.Point(167, 147);
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(303, 24);
            this.tbEnglishWord.TabIndex = 9;
            this.tbEnglishWord.Text = "english";
            this.tbEnglishWord.TextChanged += new System.EventHandler(this.tbEnglishWord_TextChanged);
            // 
            // btSaveWordsToDatabase
            // 
            this.btSaveWordsToDatabase.FlatAppearance.BorderSize = 0;
            this.btSaveWordsToDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveWordsToDatabase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSaveWordsToDatabase.ForeColor = System.Drawing.Color.White;
            this.btSaveWordsToDatabase.Image = global::EngLearningApp.Properties.Resources.save;
            this.btSaveWordsToDatabase.Location = new System.Drawing.Point(537, 380);
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
            this.button4.Location = new System.Drawing.Point(270, 188);
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
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(373, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ignore";
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
            this.lbWordsCount.Location = new System.Drawing.Point(3, 3);
            this.lbWordsCount.Name = "lbWordsCount";
            this.lbWordsCount.Size = new System.Drawing.Size(74, 21);
            this.lbWordsCount.TabIndex = 4;
            this.lbWordsCount.Text = "                ";
            // 
            // pLeftButtonPanel
            // 
            this.pLeftButtonPanel.Controls.Add(this.btl_NewWords);
            this.pLeftButtonPanel.Controls.Add(this.btl_Settings);
            this.pLeftButtonPanel.Controls.Add(this.btl_OldWords);
            this.pLeftButtonPanel.Controls.Add(this.btl_Questioner);
            this.pLeftButtonPanel.Controls.Add(this.btl_open);
            this.pLeftButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftButtonPanel.Location = new System.Drawing.Point(0, 34);
            this.pLeftButtonPanel.Name = "pLeftButtonPanel";
            this.pLeftButtonPanel.Size = new System.Drawing.Size(188, 482);
            this.pLeftButtonPanel.TabIndex = 7;
            // 
            // btl_NewWords
            // 
            this.btl_NewWords.FlatAppearance.BorderSize = 0;
            this.btl_NewWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btl_NewWords.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btl_NewWords.ForeColor = System.Drawing.Color.White;
            this.btl_NewWords.Image = global::EngLearningApp.Properties.Resources._new;
            this.btl_NewWords.Location = new System.Drawing.Point(3, 194);
            this.btl_NewWords.Name = "btl_NewWords";
            this.btl_NewWords.Size = new System.Drawing.Size(188, 88);
            this.btl_NewWords.TabIndex = 4;
            this.btl_NewWords.Text = "New words";
            this.btl_NewWords.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btl_NewWords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btl_NewWords.UseVisualStyleBackColor = true;
            this.btl_NewWords.Click += new System.EventHandler(this.btl_NewWords_Click);
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
            this.btl_Settings.Click += new System.EventHandler(this.btl_Settings_Click);
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
            this.btl_OldWords.Click += new System.EventHandler(this.btl_OldWords_Click);
            // 
            // btl_Questioner
            // 
            this.btl_Questioner.FlatAppearance.BorderSize = 0;
            this.btl_Questioner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btl_Questioner.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btl_Questioner.ForeColor = System.Drawing.Color.White;
            this.btl_Questioner.Image = global::EngLearningApp.Properties.Resources.questioner;
            this.btl_Questioner.Location = new System.Drawing.Point(3, 100);
            this.btl_Questioner.Name = "btl_Questioner";
            this.btl_Questioner.Size = new System.Drawing.Size(188, 88);
            this.btl_Questioner.TabIndex = 1;
            this.btl_Questioner.Text = "Read new file";
            this.btl_Questioner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btl_Questioner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btl_Questioner.UseVisualStyleBackColor = true;
            this.btl_Questioner.Click += new System.EventHandler(this.btl_Questioner_Click);
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
            this.pLogPanel.Controls.Add(this.lbMessage);
            this.pLogPanel.Controls.Add(this.lbWordsCount);
            this.pLogPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pLogPanel.Location = new System.Drawing.Point(188, 489);
            this.pLogPanel.Name = "pLogPanel";
            this.pLogPanel.Size = new System.Drawing.Size(667, 27);
            this.pLogPanel.TabIndex = 8;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMessage.Location = new System.Drawing.Point(609, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(58, 21);
            this.lbMessage.TabIndex = 10;
            this.lbMessage.Text = "            ";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(99, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to the english word learnel application";
            // 
            // pictureBox_WelcomeRocket
            // 
            this.pictureBox_WelcomeRocket.Image = global::EngLearningApp.Properties.Resources.Rocket;
            this.pictureBox_WelcomeRocket.InitialImage = global::EngLearningApp.Properties.Resources.Rocket;
            this.pictureBox_WelcomeRocket.Location = new System.Drawing.Point(249, 86);
            this.pictureBox_WelcomeRocket.Name = "pictureBox_WelcomeRocket";
            this.pictureBox_WelcomeRocket.Size = new System.Drawing.Size(146, 125);
            this.pictureBox_WelcomeRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_WelcomeRocket.TabIndex = 1;
            this.pictureBox_WelcomeRocket.TabStop = false;
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.pictureBox_WelcomeRocket);
            this.panelWelcome.Controls.Add(this.label2);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWelcome.Location = new System.Drawing.Point(188, 34);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(667, 455);
            this.panelWelcome.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.panelQuestioner);
            this.Controls.Add(this.panelShowUnKnownList);
            this.Controls.Add(this.panelWelcome);
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
            this.panelShowUnKnownList.ResumeLayout(false);
            this.panelShowUnKnownListBottomPanel.ResumeLayout(false);
            this.panelQuestioner.ResumeLayout(false);
            this.panelQuestioner.PerformLayout();
            this.pLeftButtonPanel.ResumeLayout(false);
            this.pLogPanel.ResumeLayout(false);
            this.pLogPanel.PerformLayout();
            this.pTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WelcomeRocket)).EndInit();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelShowUnKnownList;
        private System.Windows.Forms.Panel panelQuestioner;
        private System.Windows.Forms.Label lbWordsCount;
        private System.Windows.Forms.Panel pLeftButtonPanel;
        private System.Windows.Forms.Button btl_open;
        private System.Windows.Forms.Panel pLogPanel;
        private System.Windows.Forms.Panel pTopPanel;
        private System.Windows.Forms.Button btl_Settings;
        private System.Windows.Forms.Button btl_OldWords;
        private System.Windows.Forms.Button btl_Questioner;
        private System.Windows.Forms.Button btl_NewWords;
        private System.Windows.Forms.Button btSaveWordsToDatabase;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btt_close;
        private System.Windows.Forms.Button btt_Minimalize;
        private System.Windows.Forms.RichTextBox rtb_ShowWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_WelcomeRocket;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.TextBox tbEnglishWord;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Panel panelShowUnKnownListBottomPanel;
        private System.Windows.Forms.Button bt_NwB_Copy;
        private System.Windows.Forms.Button bt_NwB_openWeb;
        private System.Windows.Forms.Button bt_NwB_KnowledgeChecking;
    }
}

