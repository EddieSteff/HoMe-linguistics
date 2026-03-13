using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Classification
{
    public partial class Form1 : Form
    {
        String filepath;
        String content;
        Dictionary<String, double> spam = new Dictionary<string, double>();

        public Form1()
        {
            InitializeComponent();

            spam.Add("cash", 0.99);
            spam.Add("v", 0.1);
            spam.Add("win", 0.20);
            spam.Add("prize", 0.50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFile();
            AddTXT();
        }

        public void openFile()
        { 

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowDialog();

            filepath = openFileDialog.FileName;
            var fileStream = openFileDialog.OpenFile();
            StreamReader reader = new StreamReader(fileStream);
            content = reader.ReadToEnd();
        }

        public void AddTXT()
        {
            double P_spam = 1;
            double P_notspam = 1;
            String[] word;

            if (content.Length == 0) richTextBox1.Text = "File is empty";
            else
            {
                richTextBox1.Text = content;
                word = content.Split(' ', '.', ',', '?', '!');
                foreach(String element in word)
                {
                    if (spam.ContainsKey(element))
                    {
                        double val;
                        spam.TryGetValue(element, out val);

                        P_spam *= val;
                        P_notspam *= 1 - val;
                    }
                }

                if (P_spam > P_notspam)
                {
                    label2.Text = "spam";
                    label2.ForeColor = Color.Red;
                }
                else
                {
                    label2.Text = "not spam";
                    label2.ForeColor = Color.Green;
                }

            }

            
        }
    }
}
