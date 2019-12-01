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
   public class ComparingTriplets
    {

        // Complete the compareTriplets function below.
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {

            int counterA = 0;
            int counterB = 0;

            for (int i = 0; i <= 2; i++)
            {

                    if (a[i] > b[i])
                    {
                        counterA++;

                    }
                    if (a[i] < b[i])
                    {
                        counterB++;
                    }

                }

            
            List<int> result = new List<int>()
                 { counterA,
                  counterB
                 };

            return result;

        }

        public static void Run()
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();

            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}