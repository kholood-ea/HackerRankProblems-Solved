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
    class ReverseOrderOfArray
    {
        // Complete the reverseArray function below.
        static int[] reverseArray(int[] a)
        {
            int[] b =a;
            Array.Reverse(b);
            //for (int i = 0; i <= a.Length-1; i++)
            //{
            //    b[i] = a[i];
            //}

            return b;

        }
       public static void ReadVariables()
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp)) ;
            int[] res = reverseArray(arr);
            Console.WriteLine(string.Join(" ", res));
            Console.ReadLine();

            //textWriter.WriteLine(string.Join(" ", res));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}


