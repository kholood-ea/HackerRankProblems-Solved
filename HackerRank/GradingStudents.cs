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
    public class GradingStudents
    {   public static List<int> gradingStudents(List<int> grades)
        {
            // List<string> l2 = l1.ConvertAll<string>(x => x.ToString());
            // List<string> l2 = l1.ConvertAll<string>(delegate (int i) { return i.ToString(); });
            List<int> x = new List<int>() { };
            for (int j = 0; j < grades.Count; j++)
            {
                if (grades[j] <= 37 || grades[j] ==100)
                {
                    x.Add(grades[j]);
                }
                if (grades[j] > 37 && grades[j] < 100)
                {
                    if (grades[j]%5==3)
                    {
                        x.Add(grades[j] + 2);

                    }
                    if (grades[j] % 5 == 4)
                    {
                        x.Add(grades[j] + 1);

                    }
                    if (grades[j] % 5 == 0 || grades[j] % 5 == 1|| grades[j] % 5 == 2)
                    {
                        x.Add(grades[j]);

                    }
                }

            }
            //for (int k = 0; k < x.Count; k++)
            //{
            //    Console.WriteLine(x[k]);
            //}
            return x;

        }
    }

    class Solution
    {
        public static void ReadVariables()
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }
            List<int> result = GradingStudents.gradingStudents(grades);
            
            for (int k = 0; k < result.Count; k++)
            {
                Console.WriteLine(result[k]);
            }
            // Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
