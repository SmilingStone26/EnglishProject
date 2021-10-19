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
            ScoreText.Text = "";
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
            int score = 0;
            var data = e.Data.GetData(DataFormats.FileDrop);
            

            if (checkBox1.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (data != null)
                    {
                        var fileNames = data as string[];
                        if (fileNames.Length > 0)
                        {
                            richTextBox1.Text = readfile(@fileNames[0]);
                        }
                    }

                    if (richTextBox2.Text != "")
                    {
                        List<string> stringListProf = richTextBox1.Text.Split('\n').ToList();
                        List<string> stringListEleve = richTextBox2.Text.Split('\n').ToList();
                        if (stringListEleve.Count != stringListProf.Count)
                        {
                            System.Diagnostics.Debug.WriteLine("Nombre de ligne différent");
                        }
                        else
                        {
                            for (int i = 0; i < stringListProf.Count - 1; i++)
                            {
                                if (stringListEleve[i] == stringListProf[i])
                                {
                                    score++;
                                }
                            }
                        }

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }

            }
            else
            {
                if (data != null)
                {
                    var fileNames = data as string[];
                    if (fileNames.Length > 0)
                    {
                        richTextBox1.Text = readfile(@fileNames[0]);
                    }
                }

                if (richTextBox2.Text != "")
                {
                    List<string> stringListProf = richTextBox1.Text.Split('\n').ToList();
                    List<string> stringListEleve = richTextBox2.Text.Split('\n').ToList();
                    if (stringListEleve.Count != stringListProf.Count)
                    {
                        System.Diagnostics.Debug.WriteLine("Nombre de ligne différent");
                    }
                    else
                    {
                        for (int i = 0; i < stringListProf.Count - 1; i++)
                        {
                            if (stringListEleve[i] == stringListProf[i])
                            {
                                score++;
                            }
                        }
                    }

                }
            }

            this.ScoreText.Text = score.ToString();

        }

        private void DragEleveText(object sender, DragEventArgs e)
        {
            int score = 0;
            var data = e.Data.GetData(DataFormats.FileDrop);
            

            if (checkBox2.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (data != null)
                    {
                        var fileNames = data as string[];
                        if (fileNames.Length > 0)
                        {
                            richTextBox2.Text = readfile(@fileNames[0]);
                        }
                    }

                    if (richTextBox1.Text != "")
                    {
                        List<string> stringListProf = richTextBox1.Text.Split('\n').ToList();
                        List<string> stringListEleve = richTextBox2.Text.Split('\n').ToList();
                        if (stringListEleve.Count != stringListProf.Count)
                        {
                            System.Diagnostics.Debug.WriteLine("Nombre de ligne différent");
                        }
                        else
                        {
                            for (int i = 0; i < stringListProf.Count - 1; i++)
                            {
                                if (stringListEleve[i] == stringListProf[i])
                                {
                                    score++;
                                }
                            }
                        }

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }

            }
            else
            {
                if (data != null)
                {
                    var fileNames = data as string[];
                    if (fileNames.Length > 0)
                    {
                        richTextBox2.Text = readfile(@fileNames[0]);
                    }
                }

                if (richTextBox1.Text != "")
                {
                    List<string> stringListProf = richTextBox1.Text.Split('\n').ToList();
                    List<string> stringListEleve = richTextBox2.Text.Split('\n').ToList();
                    if (stringListEleve.Count != stringListProf.Count)
                    {
                        System.Diagnostics.Debug.WriteLine("Nombre de ligne différent");
                    }
                    else
                    {
                        for (int i = 0; i < stringListProf.Count - 1; i++)
                        {
                            if (stringListEleve[i] == stringListProf[i])
                            {
                                score++;
                            }
                        }
                    }

                }
            }

            this.ScoreText.Text = score.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
