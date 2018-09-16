using EngLearningApp.DAO;
using EngLearningApp.model;
using EngLearningApp.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace EngLearningApp
{
    public partial class Form1 : Form
    {
        private string filePath { get; set; }
        private List<string> wordsFromFile = new List<string>();
        private List<Word> wordsFromDatabase = new List<Word>();
        private Questioner questioner;

        #region Constructor
        public Form1()
        {
            InitializeComponent();

            #region Test file path
            //filePath = @"C:\Users\sypy\Downloads\HarryPotterAndTheSorceresStone.pdf";
            filePath = @"F:\Dev\videoCourses\Udemy - Spring Framework 5 Beginner to Guru\02 Building a Spring Boot Web App\009 Open Project in IntelliJ-subtitle-en.vtt";

            #endregion

            questioner = new Questioner(lbWordsCount, tbEnglishWord);

            wordsFromDatabase = new Database().initializeInMemoryList();

            new FileReader().read(filePath);

        }
        #endregion

        #region Panel: Top bar
        private void btt_Minimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btt_close_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }


        #region Windows position whitout border
        private bool mouseDown;
        private Point lastLocation;

        private void pTopPane_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pTopPane_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pTopPane_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        #endregion

        #endregion

        #region Panel: Left bar
        private void btl_open_Click(object sender, EventArgs e)
        {

            #region File chooser
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.filePath = openFileDialog1.FileName;
            }
            #endregion

            #region Read file to list
            FileReader fileReader = new FileReader();
            StringToList textFormatter = new StringToList();

            string fullText = fileReader.read(filePath);
            wordsFromFile = textFormatter.getList(fullText, wordsFromDatabase);

            //Translator d = new Translator();
            //wordDirectory = d.getDirectory(wordSet);
            #endregion

            message("File reading is successfull...");

        }

        private void btl_Questioner_Click(object sender, EventArgs e)
        {
            if(tbEnglishWord.Text.Equals("english"))
                questioner.questionTheNextWord(wordsFromFile);

            panelWelcome.Visible = false;
            panelShowUnKnownList.Visible = false;
            panelQuestioner.Visible = true;
            message("Questions started...");
        }

        private void btl_NewWords_Click(object sender, EventArgs e)
        {
            rtb_ShowWords.Text = "";
#warning fix it newRedWords find good place
            var newRedWords = questioner.getNewWords().Where(x => x.knowledgeLevel == model.KnownColor.Red).Select(x => x.english);
            foreach (var word in newRedWords)
            {
                rtb_ShowWords.Text += word + "\n";
            }
            panelWelcome.Visible = false;
            panelShowUnKnownList.Visible = true;
            panelQuestioner.Visible = false;
        }

        private void btl_OldWords_Click(object sender, EventArgs e)
        {
            rtb_ShowWords.Text = "";
            foreach (var word in wordsFromDatabase.Where(x=> x.knowledgeLevel== model.KnownColor.Red))
            {
                rtb_ShowWords.Text += word.english + "\n";
            }
            panelWelcome.Visible = false;
            panelShowUnKnownList.Visible = true;
            panelQuestioner.Visible = false;
        }

        private void btl_Settings_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Panel: Questioner

        #region Colored button
        private void btGreen_Click(object sender, EventArgs e)
        {
            askAWord(model.KnownColor.Green);
        }        

        private void btYellow_Click(object sender, EventArgs e)
        {
            askAWord(model.KnownColor.Yellow);
        }

        private void btRed_Click(object sender, EventArgs e)
        {
            askAWord(model.KnownColor.Red);
        }

        private void askAWord(model.KnownColor color)
        {
            questioner.addWordToNewWordsList(color);
            questioner.questionTheNextWord(wordsFromFile);
        }
        #endregion

        #region Save button
        private void btSaveWordsToDatabase_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void saveData()
        {
            new Database().saveData(questioner.getNewWords());
            questioner.setNewWordsAnEmptyList();
            message("Words is saved...");
        }
        #endregion

        #region Question textbox
        private void tbEnglishWord_TextChanged(object sender, EventArgs e)
        {
            questioner.setQuestionedWord(tbEnglishWord.Text);
        }
        #endregion

        #endregion


        #region Protected methods
        /// <summary>
        /// This method show a confirm box, if user wants close the app, but it has new words whitout save to database.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (!questioner.getNewWordsIsEmpty())//new words not empty
            {
                // Confirm user wants to close
                switch (MessageBox.Show(this, "Save new words?", "Closing", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        saveData();
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        e.Cancel = true;
                        break;
                }
            }
        }
        #endregion

        #region Private methods
        public void message(string message)
        {
            lbMessage.Text = message;
        }
        #endregion

    }
}
