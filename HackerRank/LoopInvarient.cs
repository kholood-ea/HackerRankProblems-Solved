using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
  public  class LoopInvarient
    {
        public static void insertionSort(int[] A)
        {

            for (int i = 1; i < A.Length; i++)
            {
                int value = A[i];
                int j = i;
                while (j > 0 && A[j - 1] > value)
                {
                    A[j] = A[j - 1];
                    j--;
                }
                A[j] = value;
            }
        
            Console.WriteLine(string.Join(" ", A));
            
        }
   public static void ReadVariables()
    {
        Console.ReadLine();
        int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        insertionSort(_ar);
            Console.ReadLine();
    }
    }
}
