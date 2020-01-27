using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class The_Hurdle_Race
    {
        // Complete the hurdleRace function below.
        public static int hurdleRace(int k, int[] height)
        {
            int magicPotionCount=0;
            int maxHeight=0;
            for (int i = 0; i < height.Length; i++)
            {
                if (k>=maxHeight)
                {
                    magicPotionCount= 0;
                }
                if (k<maxHeight)
                {
                    magicPotionCount = maxHeight - k;
                }
                if (height[i]>maxHeight)
                {
                    maxHeight = height[i];
                }
            }
            return magicPotionCount;
            

        }

        public static void ReadVariables()
        {

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);
            Console.WriteLine(result);
            Console.ReadLine();

            
        }
    }
}
