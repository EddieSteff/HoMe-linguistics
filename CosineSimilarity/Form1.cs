using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CosSim
{
    public partial class Form1 : Form
    {
        String filepath;
        String content;
        String[] Swords = { "for", "or","as", "and", "and", "of", "because", "at", "not", "is", "are", "was", "were", "the", "a", "it", "they" };
        Dictionary<String, double>[] texts = new Dictionary<string, double>[4];
        


        public Form1()
        {
            InitializeComponent();

            String[] file = { "d:\\text1", "d:\\text2", "d:\\text3" };
            for (int i = 0; i < 3; i++)
            {
                texts[i] = create_dict(file[i]);
            }

            AddToTextBox(ref dictionaryTXT1, texts[0]);
            AddToTextBox(ref dictionaryTXT2, texts[1]);
            AddToTextBox(ref dictionaryTXT3, texts[2]);
        }

        public void AddToTextBox(ref RichTextBox box, Dictionary<String, double> dict)
        {
            for(int i=0; i<dict.Count; i++)
            {
                box.AppendText(dict.Keys.ElementAt(i) + " - " + dict.Values.ElementAt(i) + "\n");
            }
        }
        private void deleteWords(ref Dictionary<String, double> dict)
        {
            for (int i = 0; i < Swords.Length; i++)
            {
                if (dict.ContainsKey(Swords[i])) dict.Remove(Swords[i]);
            }
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
            reader.Close();
        }

        public Dictionary<String, double> add_txt()
        {
            String[] word;
            Dictionary<String, double> dict = new Dictionary<String, double>();
            if (content.Length == 0)
            {
                richTextBox1.Text = "File is empty";
                return null;
            }
            else
            {
                richTextBox1.Text = content;
                word = content.Split(new char[] { ')', '(', '\u0022', ' ', '\t', '\r', '\n', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (String element in word)
                {
                    if (!dict.ContainsKey(element)) dict.Add(element, 1);
                    else dict[element] += 1;
                }
            }

            AddToTextBox(ref dictionaryOPENED, dict);
            
            return dict;
        }

        public Dictionary<String, double> create_dict(String filename)
        {
            Dictionary<String, double> sample_dict = new Dictionary<string, double>();
            StreamReader reader = new StreamReader(File.Open(filename + ".bin", FileMode.OpenOrCreate, FileAccess.Read));
            content = reader.ReadToEnd();
            content.ToLower();
            reader.Close();


            String[] word = content.Split(new char[]{' ', '\t', '\r', '\n', '.', ',', '?', '!'},StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < word.Length; i++)
            {
                if (!sample_dict.ContainsKey(word[i])) sample_dict.Add(word[i], 1);
                else sample_dict[word[i]] += 1;
            }
            return (sample_dict);
        }

        private Dictionary<String, double> AddDict(Dictionary<string, double> dict)
        {
            Dictionary<String, double> newDict = new Dictionary<string, double>();
            foreach(KeyValuePair<String, double> word in dict)
            {
                newDict.Add(word.Key, word.Value);
            }

            return newDict;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] sum = { 0, 0, 0, 0 };
            double[] cos = new double[3];
            double[,] softCos = new double[3,4];

            Dictionary<String, double>[] cosineSampleTexts = new Dictionary<string, double>[4];
            Dictionary<String, double>[] softCosineSampleTexts = new Dictionary<string, double>[3];
            Dictionary<String, double>[] softCosineOrig = new Dictionary<String, double>[3];

            for(int i=0; i<4; i++)
            {
                cosineSampleTexts[i] = AddDict(texts[i]);
                deleteWords(ref cosineSampleTexts[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                softCosineSampleTexts[i] = AddDict(texts[i]);
                softCosineOrig[i] = AddDict(texts[3]);
                softCosineOrig[i] = SoftCosine.IncDictionary(softCosineOrig[i], ref softCosineSampleTexts[i]);
            }

            for(int i=0; i<3; i++)
            {
                deleteWords(ref softCosineOrig[i]);
                deleteWords(ref softCosineSampleTexts[i]);
            }
        
            for (int i=0; i< cosineSampleTexts.Length; i++)
            {
                Cosine.find_wt(ref cosineSampleTexts[i], ref sum[i]);
                if (withIDF.Checked) Cosine.find_idf(ref cosineSampleTexts[i], cosineSampleTexts);
                Cosine.normalize(ref cosineSampleTexts[i], sum[i]);


            }


            for(int i=0; i<3; i++)
            {
                cos[i] = Math.Round(Cosine.find_cos(cosineSampleTexts[i], cosineSampleTexts[3]), 4);
                
            }

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<4; j++)
                {
                    softCos[i,j] = Math.Round(SoftCosine.FindSoftCosine(j+1, softCosineOrig[i], softCosineSampleTexts[i]), 4);
                }
            }


            cosLABELtxt1.Text = cos[0].ToString();
            cosLABELtxt2.Text = cos[1].ToString();
            cosLABELtxt3.Text = cos[2].ToString();

            softCosLABELtxt1F1.Text = softCos[0,0].ToString();
            softCosLABELtxt1F2.Text = softCos[0,1].ToString();
            softCosLABELtxt1F3.Text = softCos[0,2].ToString(); 
            softCosLABELtxt1F4.Text = softCos[0,3].ToString();

            softCosLABELtxt2F1.Text = softCos[1, 0].ToString();
            softCosLABELtxt2F2.Text = softCos[1, 1].ToString();
            softCosLABELtxt2F3.Text = softCos[1, 2].ToString();
            softCosLABELtxt2F4.Text = softCos[1, 3].ToString();

            softCosLABELtxt4F1.Text = softCos[2, 0].ToString();
            softCosLABELtxt4F2.Text = softCos[2, 1].ToString();
            softCosLABELtxt4F3.Text = softCos[2, 2].ToString();
            softCosLABELtxt4F4.Text = softCos[2, 3].ToString();
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            openFile();
            texts[3] = add_txt();

        }
    }
}
 