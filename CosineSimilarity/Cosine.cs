using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosSim
{
    class Cosine
    {
        public static void find_wt(ref Dictionary<String, double> dict, ref double sum)
        {
            for (int i = 0; i < dict.Count(); i++)
            {
                dict[dict.Keys.ElementAt(i)] = 1 + Math.Log10(dict.Values.ElementAt(i));
                sum += Math.Pow(dict.Values.ElementAt(i), 2);
            }
        }

        public static void find_idf(ref Dictionary<String, double> dict, Dictionary<String, double>[] texts)
        {
            double idf;
            for (int i = 0; i < dict.Count(); i++)
            {
                idf = Math.Log10(texts.Length / if_contains(dict.Keys.ElementAt(i), texts));
                dict[dict.Keys.ElementAt(i)] *= idf;
            }

        }

        public static int if_contains(String element, Dictionary<String, double>[] texts)
        {
            int df = 0;

            for (int i = 0; i < texts.Length; i++)
            {
                if (texts[i].Keys.Contains(element)) df++;
            }

            return df;
        }

        public static void normalize(ref Dictionary<String, double> dict, double sum)
        {
            for (int i = 0; i < dict.Count(); i++)
            {
                dict[dict.Keys.ElementAt(i)] /= Math.Sqrt(sum);
            }
        }

        public static double find_cos(Dictionary<String, double> dict, Dictionary<String, double> sample)
        {
            double cos = 0;
            for (int i = 0; i < Math.Min(dict.Count, sample.Count); i++)
            {
                if (sample.Keys.Contains(dict.Keys.ElementAt(i))) cos += dict.Values.ElementAt(i) * sample[dict.Keys.ElementAt(i)];
                else cos += 0;
            }

            return cos;
        }
    }
}
