using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank
{
  public  class PlusMinusFraction
    {

        // Complete the plusMinus function below.
        public static List<float> plusMinus(int[] arr)
        {
            float positive = 0, negative = 0, zeros = 0;
            List<float> ar= new List<float>() ;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positive++;

                }
                if (arr[i] < 0)
                {
                    negative++;

                }
                if (arr[i] == 0)
                {
                    zeros++;
                }
            }
            //ar.Add($"{(positive / arr.Length):F6}");
            //ar.Add($"{(negative / arr.Length):F6}");
            //ar.Add($"{(zeros / arr.Length):F6}");
            float p, n, z;
            p = positive / arr.Length;
            n = negative / arr.Length;
            z = zeros / arr.Length;
            ar.Add(p);
            ar.Add(n);
            ar.Add(z);
            for (int j = 0; j < ar.Count(); j++)
                {
                    Console.WriteLine($"{ar[j]:F6}");

                }
                Console.ReadLine();
            
            return ar;
            //open the project
        }
            // Complete the plusMinus function below.
        //    public static void plusMinus(int[] arr)
        //{
        //    float positive = 0, negative=0,zeros=0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i]>0)
        //        {
        //            positive++;

        //        }
        //        if (arr[i] < 0)
        //        {
        //            negetive++;

        //        }
        //        if (arr[i] == 0)
        //        {
        //            zeros++;

        //        }
        //    }

        //    // Console.WriteLine(positive/arr.Length);
        //    // Console.WriteLine($"{0:F6}",(positive / arr.Length));
        //   // Console.WriteLine(Math.Round (1000000f*(positive / arr.Length)));
        //   // Console.WriteLine(Math.Round(1000000f * (positive / arr.Length)));
        //   // Console.WriteLine(Math.Round (negetive/arr.Length));
        //    //$"{1234.5678:F5}"          "1234.56780"     5 digits after the decimal point, notice the trailing zero
        //    Console.WriteLine($"{positive / arr.Length:F6}");
        //    Console.WriteLine($"{negative / arr.Length:F6}");
        //    Console.WriteLine($"{zeros/arr.Length:F6}");
        //    Console.ReadLine();



        //}

        public static void ReadVariables()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }
    }
}







