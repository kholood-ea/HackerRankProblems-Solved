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
  public  class DiagonalDifference
    {
       public class Result
{

    public static int diagonalDifference(List<List<int>> arr)
    {
                var lr = 0; var rl = 0;
                for (var i = 0; i < arr.Count; i++)
                {
                    lr += arr[i][i];
                    rl += arr[i][arr.Count - i - 1];
                }
                int result = Math.Abs(lr - rl);
                return result;

            }


}
    public static void ReaVariables()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);
            Console.WriteLine(result);
            Console.ReadLine();

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
    }
}


