using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace LSA
{
    public partial class Form1 : Form
    {
        String filepath;
        String content;
        String[] Swords = { "for", "", "as", "and", "and", "of", "because", "at", "not", "is", "are", "was", "were", "the", "a", "it", "they" };
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

        private void deleteWords(ref Dictionary<String, double> dict)
        {
            for(int i=0; i<Swords.Length; i++)
            {
                if (dict.ContainsKey(Swords[i])) dict.Remove(Swords[i]);
            }
        }

        public void AddToTextBox(ref RichTextBox box, Dictionary<String, double> dict)
        {
            for (int i = 0; i < dict.Count; i++)
            {
                box.AppendText(dict.Keys.ElementAt(i) + " - " + dict.Values.ElementAt(i) + "\n");
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
                word = content.Split(new char[] { ')', '(', '\u0022',  ' ', '\t', '\r', '\n', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
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


            String[] word = content.Split(new char[] { ' ', '\t', '\r', '\n', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

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
            foreach (KeyValuePair<String, double> word in dict)
            {
                newDict.Add(word.Key, word.Value);
            }

            return newDict;
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            openFile();
            texts[3] = add_txt();
        }

        private void incDictionary(ref Dictionary<String, double>[] dict)
        {
           for(int i=0; i<dict.Length; i++)
            {
                for(int j=0; j<dict.Length; j++)
                {
                    for(int k=0; k<dict[j].Count; k++)
                    {
                        if (!dict[i].ContainsKey(dict[j].Keys.ElementAt(k))) dict[i].Add(dict[j].Keys.ElementAt(k), 0);
                    }
                }
            }
        }

        private Dictionary<String, double> setOrder (Dictionary<String, double> dict)
        {
            Dictionary<String, double> refDict1 = new Dictionary<String, double>();
            foreach (KeyValuePair<String, double> word in dict.OrderBy(key => key.Key))
            {
                refDict1.Add(word.Key, word.Value);
            }

            return refDict1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double[] cos = new double[3];

            double[,] matrixM;
            double[,] matrixMT;
            double[,] resMatrixU;
            double[,] resMatrixVT;
            double[,] svdVT;

            Dictionary<String, double>[] cosineSampleTexts = new Dictionary<string, double>[4];

            for (int i = 0; i < 4; i++)
            {
                cosineSampleTexts[i] = AddDict(texts[i]);
            }
            incDictionary(ref cosineSampleTexts);
            
            for(int i=0; i<cosineSampleTexts.Length; i++)
            {
                deleteWords(ref cosineSampleTexts[i]);
                cosineSampleTexts[i] = setOrder(cosineSampleTexts[i]);
            }

            int words = cosineSampleTexts[0].Count;
            int docs = cosineSampleTexts.Length;

            matrixM = TMatrix.CreateArrM(cosineSampleTexts);
            matrixMT = TMatrix.MetrixT(cosineSampleTexts[0].Count, docs, matrixM);

            resMatrixU = TMatrix.MultipleMatr(matrixM, matrixMT);
            resMatrixU = TMatrix.EigenVector(resMatrixU, words);
            resMatrixU = TMatrix.roundArr(resMatrixU, words);

            resMatrixVT = TMatrix.MultipleMatr(matrixMT, matrixM);
            resMatrixVT = TMatrix.EigenVector(resMatrixVT, docs);
            resMatrixVT = TMatrix.MetrixT(docs, docs, resMatrixVT);
            resMatrixVT = TMatrix.roundArr(resMatrixVT, docs);
            resMatrixVT = TMatrix.toPos(resMatrixVT, docs);

            svdVT = TMatrix.svd(matrixM);

            matrixMBox.AppendText("\tText1 Text2 Text3 Opened\n\n");
            for(int i=0; i<words; i++)
            {
                matrixMBox.AppendText(cosineSampleTexts[0].Keys.ElementAt(i) + "  ");
                for (int j=0; j<docs; j++)
                {
                    matrixMBox.AppendText(matrixM[i,j] + " ");
                }
                matrixMBox.AppendText("\n");
            }

            for(int i=0; i< words; i++)
            {
                matrixU.AppendText(cosineSampleTexts[0].Keys.ElementAt(i) + "  " );
                for (int j=0; j< words; j++)
                {
                    matrixU.AppendText(resMatrixU[i, j] + " ");
                }

                matrixU.AppendText("\n");
            }

            
            matrixV.AppendText("Text1 Text2 Text3 Opened\n");
            for (int i=0; i< docs; i++)
            {
                
                for(int j=0; j<docs; j++)
                {
                    matrixV.AppendText(resMatrixVT[i, j] + " ");
                }
                matrixV.AppendText("\n");
            }

            cos = TMatrix.cosine(resMatrixVT, docs);

            cosLABELtxt1.Text = Math.Round(cos[0], 3).ToString();
            cosLABELtxt2.Text = Math.Round(cos[1], 3).ToString();
            cosLABELtxt3.Text = Math.Round(cos[2], 3).ToString();

        }


    }
}
