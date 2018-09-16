using System;
using System.Windows.Forms;

namespace EngLearningApp.service
{
    class Logger
    {
        public void messageBox(Exception e)
        {
            MessageBox.Show("ERROR: " + e.ToString());
        }

        public void statusPanel(Exception e)
        {
#warning implement
        }
        
        public void error(Exception e)
        {
#warning implement: write somewhere... database?
        }
    }
}
