using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosSim
{
    class SoftCosine
    {


        public static int LevensteinDistance(string str1, string str2)
        {
            if (!str1.Equals(str2))
            {
                int[,] arr = new int[str1.Length+1, str2.Length+1];

                for (int i = 0; i < str1.Length+1; i++)
                {
                    
                    arr[i, 0] = i;
                    
                }

                for (int j = 0; j < str2.Length+1; j++)
                {
                    arr[0, j] = j;
                }

                for (int i = 1;  i < str1.Length+1; i++)
                {
                    for (int j = 1; j < str2.Length+1;  j++)
                     {
                          int m = 1;
                           if (str1[i-1] == str2[j-1]) m = 0;

                         int temp = Math.Min(arr[i, j - 1] + 1, arr[i - 1, j] + 1);
                        arr[i, j] = Math.Min(temp, arr[i - 1, j - 1] + m);

                      }
                }

                return arr[str1.Length, str2.Length];
            }

            else return 0;

        }

        public static double[,] SimMatrix(Dictionary<String, double> dict1, int FunkNumb)
        {

            double[,] arr = new double[dict1.Count(), dict1.Count()];

            for (int i = 0; i < dict1.Count(); i++)
            {
                for (int j = 0; j < dict1.Count(); j++)
                {
                    int maxVal = Math.Max(dict1.Keys.ElementAt(i).Length, dict1.Keys.ElementAt(j).Length);
                    arr[i, j] = LevensteinDistance(dict1.Keys.ElementAt(i), dict1.Keys.ElementAt(j));
                    arr[i, j] = Funktion(arr[i, j], FunkNumb, maxVal);
                }
            }

            return arr;
        }

        public static Dictionary<String, double> IncDictionary(Dictionary<String, double> dict1, ref Dictionary<String, double> dict2)
        {
            Dictionary<String, double> refDict1 = new Dictionary<String, double>();
            Dictionary<String, double> refDict2 = new Dictionary<String, double>();
            for (int i = 0; i < dict2.Count(); i++)
            {
                if (!dict1.ContainsKey(dict2.Keys.ElementAt(i))) dict1.Add(dict2.Keys.ElementAt(i), 0);
            }

            for (int i = 0; i < dict1.Count(); i++)
            {
                if (!dict2.ContainsKey(dict1.Keys.ElementAt(i))) dict2.Add(dict1.Keys.ElementAt(i), 0);
            }

            foreach (KeyValuePair<String, double> word in dict1.OrderBy(key => key.Key))
            {
                refDict1.Add(word.Key, word.Value);
            }

            foreach (KeyValuePair<String, double> word in dict2.OrderBy(key => key.Key))
            {
                refDict2.Add(word.Key, word.Value);
            }

            dict2 = refDict2;

            return refDict1;
        }

        public static double Funktion(double val, int funkNumb, int maxDist)
        {
            {
                switch (funkNumb)
                {
                    case 1:
                        return 1 / (1 + val);
                    case 2:
                        return Math.Pow(1 - val / maxDist, 2);
                    case 3:
                        return 1 - val / maxDist;
                    case 4:
                        return Math.Sqrt(1 - val / maxDist);
                    default:
                        return 0;
                }
            }
        }

        public static double FindSoftCosine(int FinkNumb, Dictionary<String, double> dict1, Dictionary<String, double> dict2)
        {
            double VecSum = 0;
            double VecSumA = 0;
            double VecSumB = 0;

            double[,] arr= SimMatrix(dict1, FinkNumb);
            for (int i=0; i<dict1.Count(); i++)
            {
                for(int j=0; j<dict1.Count; j++)
                {
                    VecSum += arr[i, j] * dict1.Values.ElementAt(i) * dict2.Values.ElementAt(j);
                    VecSumA += arr[i, j] * dict1.Values.ElementAt(i) * dict1.Values.ElementAt(j);
                    VecSumB += arr[i, j] * dict2.Values.ElementAt(i) * dict2.Values.ElementAt(j);
                }
            }

            return VecSum / (Math.Sqrt(VecSumA) * Math.Sqrt(VecSumB));
        }
    }
}