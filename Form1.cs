using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.AllowDrop = true;
            richTextBox1.DragDrop += DragCorrectionText;
            richTextBox2.AllowDrop = true;
            richTextBox2.DragDrop += DragEleveText;
        }

        public string readfile(String File)
        {
            int counter = 0;
            string line;
            string text = "";

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(File);
            while ((line = file.ReadLine()) != null)
            {
                text += line + "\n";
                counter++;
            }

            file.Close();
            return text;
        }

        private void DragCorrectionText(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    richTextBox1.Text += readfile(@fileNames[0]);
                }
            }
        }

        private void DragEleveText(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    richTextBox2.Text += readfile(@fileNames[0]);
                }
            }
        }
    }
}
