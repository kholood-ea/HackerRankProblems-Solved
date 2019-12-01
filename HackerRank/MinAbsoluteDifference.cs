using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
   public class MinAbsoluteDifference
    {
     public  static int minimumAbsoluteDifference(int[] arr)
        {
            Array.Sort(arr);
            int minDiff = int.MaxValue;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff = Math.Abs(arr[i] - arr[i + 1]);
                if (diff < minDiff)
                    minDiff = diff;
            }
            return minDiff;

        }

       public static void ReadVariables()
        {

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //Console.WriteLine("Please Enter Length");
            int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Please Enter Array Elements");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int result = minimumAbsoluteDifference(arr);
            Console.WriteLine(result);

            Console.Read();

            /*   textWriter.WriteLine(result);

               textWriter.Flush();
               textWriter.Close();*/
        }
    }
}
