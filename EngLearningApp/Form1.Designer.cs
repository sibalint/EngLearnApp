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
            this.panelFileReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tbReadTextFile.Click += new System.EventHandler(this.tbReadTextFile_Click);
            // 
            // panelFileReader
            // 
            this.panelFileReader.Controls.Add(this.label1);
            this.panelFileReader.Controls.Add(this.tbReadTextFile);
            this.panelFileReader.Controls.Add(this.tbSelectTextFilePath);
            this.panelFileReader.Controls.Add(this.btSelectTextFilePath);
            this.panelFileReader.Location = new System.Drawing.Point(3, 60);
            this.panelFileReader.Name = "panelFileReader";
            this.panelFileReader.Size = new System.Drawing.Size(794, 100);
            this.panelFileReader.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFileReader);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelFileReader.ResumeLayout(false);
            this.panelFileReader.PerformLayout();
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
    }
}

