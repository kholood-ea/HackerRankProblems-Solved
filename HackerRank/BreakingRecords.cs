using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
  public class BreakingRecords
    {
      public static int[] breakingRecords(int[] scores)
        {
            int max = 0;
            int min = 0;
            int maxnum=scores[0];
            int minnum=scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
               

                if (maxnum <scores[i])
                {
                    maxnum = scores[i];
                   max++;
                }
                if (scores[i]<minnum)
                {
                    minnum = scores[i];
                    min++;

                }

            }
           
            
            Console.WriteLine($"{max} {min}");
            int[] result= {max,min };
            return result;
           
        }

       public static void ReadVariables()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int[] result = breakingRecords(scores);

           
            Console.WriteLine(string.Join(" ", result));
            
            Console.ReadLine();
           
        }
    }
}
