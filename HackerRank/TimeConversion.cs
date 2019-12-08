using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class TimeConversion
    {

        public static string timeConversion(string s)
        { 
            string s1=s.Substring(8);
            string s2=s.Substring(0,8);
            if (s1 == "AM" || s1 == "am")
            {
                if ( s2.Substring(0, 2) == "12")
                {
                    int hour = int.Parse(s2.Substring(0, 2));
                    return "00" + s2.Substring(2);
                }
                return s2;
            }
            if (s1 == "PM" || s1 == "pm" )
            {
                if (s2.Substring(0, 2) == "12")
                {
                    return s2;
                }
                int hour = int.Parse(s2.Substring(0, 2));
                return (hour + 12).ToString() + s2.Substring(2);
            }

            return s2;
        }
        public static void ReadVariables()
        {             
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
