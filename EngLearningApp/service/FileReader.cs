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
        Logger log = new Logger();

        public string readPdfToString(string filePath)
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


        public string readTxtToString(string filePath)
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


    }
}
