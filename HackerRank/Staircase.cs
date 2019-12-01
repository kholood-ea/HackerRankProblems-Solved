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
    class Staircase
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 0; i <n; i++)
            {
                
                    Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));

                

            }


        }
       public static void ReadVariables()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
            Console.ReadLine();
        }

    }
}

