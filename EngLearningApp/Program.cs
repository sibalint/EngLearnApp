using System;
using System.Windows.Forms;

namespace EngLearningApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //icon: drag and drop a file
            string path = "";
            if(args.Length>0) path = args[0];


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(path));

            
        }
    }
}
