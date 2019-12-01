using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
   public class BirthdayCandles
    {

        // Complete the birthdayCakeCandles function below.
        public static int birthdayCakeCandles(int[] ar)
        {
            if (ar.Length == 0)
                return 0;
            int count = 0;
            int max = ar[0];

            for (int i = 0; i <= ar.Length - 1; i++)
            {

                if (max == ar[i])
                {
                    count++;
                }
                else if (ar[i] > max)
                {
                    max = ar[i];
                    count = 1;
                }

            }
            return count;
        }
        public static void ReadVariables()
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            {
                int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
                int result = BirthdayCandles.birthdayCakeCandles(ar);
                Console.WriteLine(result);
                Console.ReadLine();

            }

        }
    }
}
