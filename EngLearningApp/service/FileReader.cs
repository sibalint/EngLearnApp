using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using EngLearningApp.service;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace EngLearningApp
{
    class FileReader
    {
        private Logger log = new Logger();
        private string path = Properties.Settings.Default.path;

        public void setPath(string path)
        {
            this.path = path;
            Properties.Settings.Default.path = path;
            Properties.Settings.Default.Save();
        }


        public void fileChooser(OpenFileDialog openFileDialog)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                this.setPath(openFileDialog.FileName);
        }

        public string read()
        {
            if (isPdf(path))
                return readPdf(path);
            else
                return readTxt(path);
        }        

        private string readPdf(string filePath)
        {
            try
            {
                return readPdfToString_whitoutExceptionHandling(filePath);
            }
            catch (Exception e )
            {
                MessageBox.Show("ERROR: PDF file reading failed!");
                log.error(e);
                throw;
            }
        }

        private string readPdfToString_whitoutExceptionHandling(string filePath)
        {
            StringBuilder text = new StringBuilder();

            if (File.Exists(filePath))
            {
                PdfReader pdfReader = new PdfReader(filePath);

                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                    text.Append(currentText);
                }
                pdfReader.Close();
            }

            return text.ToString();
        }

        private string readTxt(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Read Text file failed!");
                log.error(e);
                throw;
            }
        }

        private bool isPdf(string path)
        {
            path = path.ToLower().Trim();
            if (path.Length > 3 && path.Substring(path.Length - 3, 3).Equals("pdf"))
                return true;
            else return false;
        }


    }
}
