using EngLearningApp.DAO;
using EngLearningApp.model;
using EngLearningApp.service;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace EngLearningApp
{
    public partial class Form1 : Form
    {
        private List<string> wordsFromFile = new List<string>();
        private List<Word> wordsFromDatabase;

        private FileReader fileReader;
        private StringToList textFormatter;
        private Questioner questioner;


        #region Constructor
        public Form1(string argument)
        {
            InitializeComponent(); 
            
            fileReader = new FileReader();
            textFormatter = new StringToList();
            questioner = new Questioner(lbWordsCount, tbEnglishWord);

            wordsFromDatabase = new Database().initializeInMemoryList();
            
            #region Drag and drop a file?
            if (File.Exists(argument))
            {
                fileReader.setPath(argument);
                QuestionerButton();
            }

            #endregion

            #region Sandbox
            
            #endregion
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
            fileReader.fileChooser(openFileDialog1);
            btl_Questioner.Text = "Read new file";
            message("File opening is successfull...");

        }


        private void btl_Questioner_Click(object sender, EventArgs e)
        {
            QuestionerButton();
        }

        private void QuestionerButton()
        {
            if (fileReader.hasNewFile())
            {
                //read list
                string fullText = fileReader.read();
                wordsFromFile = textFormatter.getList(fullText, wordsFromDatabase);
                //start questioning
                questioner.questionTheNextWord(wordsFromFile);

                btl_Questioner.Text = "Question words";
            }

            visibility(false, false, true);
            message("Questions started...");
        }        

        private void btl_NewWords_Click(object sender, EventArgs e)
        {
            writeRedWords(wordsFromDatabase);
            visibility(false, true, false);
        }

        private void btl_OldWords_Click(object sender, EventArgs e)
        {
            writeRedWords(wordsFromDatabase);
            visibility(false, true, false);
        }

        private void writeRedWords(List<Word> words)
        {
            rtb_ShowWords.Text = "";
            foreach (var word in words.Where(x => x.knowledgeLevel == model.KnownColor.Red))
            {
                rtb_ShowWords.Text += word.english + "\n";
            }
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

        private void btRed_Click(object sender, EventArgs e)
        {
            askAWord(model.KnownColor.Red);
        }

        private void btBlack_Click(object sender, EventArgs e)
        {
            askAWord(model.KnownColor.Black);
        }        

        private void askAWord(model.KnownColor color)
        {
            questioner.addWordToNewWordsList(color);
            questioner.questionTheNextWord(wordsFromFile);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
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

        #region Panel: Show words

        private void bt_NwB_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_ShowWords.Text);
        }

        private void bt_NwB_openWeb_Click(object sender, EventArgs e)
        {
            string url = "https://translate.google.hu/#en/hu/" + rtb_ShowWords.Text.Trim().Replace("\n", "%0A");
            Process.Start(url);
        }

        private void bt_NwB_KnowledgeChecking_Click(object sender, EventArgs e)
        {
            wordsFromFile = wordsFromDatabase.Where(w => w.knowledgeLevel == model.KnownColor.Red).Select(s => s.english).OrderBy(o=>o).ToList();
            questioner.questionTheNextWord(wordsFromFile);
            fileReader.isNewFile = false;
        }

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
            if (questioner.getNewWordsIsEmpty())//new words not empty
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
        private void visibility(bool welcomePanel, bool showWordsPanel, bool questionerPanel)
        {
            panelWelcome.Visible = welcomePanel;
            panelShowUnKnownList.Visible = showWordsPanel;
            panelQuestioner.Visible = questionerPanel;
        }

        public void message(string message)
        {
            lbMessage.Text = message;
        }



        #endregion

    }
}
