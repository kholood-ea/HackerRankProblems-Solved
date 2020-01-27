using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class ViralAdvertising
    {
        // Complete the viralAdvertising function below.
        static int viralAdvertising(int n)
        {
            int ppl = 5;
            int allLikingPpl=0;

            for (int i = 0; i < n; i++)
            {

            int likingPpl = ppl / 2;
            allLikingPpl +=likingPpl;
            const int three = 3;
            int nextDayPpl = likingPpl * three;
            ppl = nextDayPpl;
            }
            return allLikingPpl;
          //  int nextDayLikingPpl = nextDayPpl / 2;
          // int allLikingPpl = likingPpl + nextDayLikingPpl;     
        }

     public static void ReadVariables()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int result = viralAdvertising(n);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}