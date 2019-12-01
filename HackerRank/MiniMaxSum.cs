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
    public class MiniMaxSum
    {

        // Complete the miniMaxSum function below.
        public static void miniMaxSum(int[] arr)

        {
            long[] longAr = arr.Select(b => Convert.ToInt64(b)).ToArray();
            long result1 = longAr.Sum() - arr.Max();
            long result2 = longAr.Sum() - arr.Min();
            Console.WriteLine($"{result1} {result2}");
            Console.ReadLine();

        }

        public static void ReadVariables()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
