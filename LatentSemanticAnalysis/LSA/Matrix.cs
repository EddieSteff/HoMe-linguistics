using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Factorization;
using System.Numerics;


namespace LSA
{
    class TMatrix
    {


        public static double[,] CreateArrM(Dictionary<String, double>[] texts)
        {
            double[,] arr = new double[texts[0].Count, texts.Length];

            for (int i = 0; i < texts[0].Count; i++)
            {
                for (int j = 0; j < texts.Length; j++)
                {
                    arr[i, j] = texts[j].Values.ElementAt(i);
                }
            }

            return arr;
        }

        public static double[,] MetrixT(int n, int m, double[,] arr)
        {
            double[,] arrT = new double[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arrT[i, j] = arr[j, i];
                }
            }

            return arrT;
        }

        public static double[,] MultipleMatr(double[,] arr1, double[,] arr2)
        {

            Matrix<double> matr1 = Matrix<double>.Build.DenseOfArray(arr1);
            Matrix<double> matr2 = Matrix<double>.Build.DenseOfArray(arr2);
            Matrix<double> result = matr1*matr2;
            

            return result.ToArray();
        }

        public static double[,] EigenVector(double[,] arr, int n)
        {
            double[,] eigenVectors = new double[n, n];
            Matrix<double> processedData = Matrix<double>.Build.DenseOfArray(arr);
            Evd<double> eigen = processedData.Evd();
            Matrix<double> eigenVectorMatrix = eigen.EigenVectors;
            eigenVectors = eigenVectorMatrix.ToArray();
            return eigenVectors;
        }

        public static double[,] NewMatrix(double[,] arr, int n, int m)
        {
            double[,] newArr = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newArr[i, j] = arr[i, j];
                }
            }

            return newArr;
        }

        public static double[,] roundArr(double[,] arr, int n)
        {
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    arr[i, j] = Math.Round(arr[i, j], 3);
                }
            }

            return arr;
        }

        public static double[,] svd(double[,]arr)
        {
            Matrix<double> processedData = Matrix<double>.Build.DenseOfArray(arr);
            Svd<double> eigen = processedData.Svd();
            Matrix<double> eigenVectorMatrix = eigen.VT;

            return eigenVectorMatrix.ToArray();
        }

        public static double[] cosine(double[,] arr, int n)
        {
            double[] sum = new double[n];
            double[] cosine = new double[n];

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    sum[i] += arr[j, i] * arr[j, i];
                }

                sum[i] = Math.Sqrt(sum[i]);
            }

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    
                    cosine[i] += arr[j, i] * arr[j, n-1];
                    
                }
                cosine[i] /= sum[i] * sum[n - 1];
            }

            return cosine;
        }

        public static double[,] toPos(double[,] arr, int n)
        {
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if (arr[i, j] < 0) arr[i, j] = arr[i, j] * (-2);
                }
            }
            return arr;
        }
    }
}
