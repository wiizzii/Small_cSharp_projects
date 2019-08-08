using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Small_projects
{
    public class Count_Vowels
    {
        public static void CountVowels()
        {
            string OriginalString = Console.ReadLine();
            int TotalA = OriginalString.Count(c => "Aa".Contains(c));
            int TotalE = OriginalString.Count(c => "Ee".Contains(c));
            int TotalI = OriginalString.Count(c => "Ii".Contains(c));
            int TotalO = OriginalString.Count(c => "Oo".Contains(c));
            int TotalU = OriginalString.Count(c => "Uu".Contains(c));

            int TotalVowels = TotalA + TotalE + TotalI + TotalO + TotalU;

            Console.WriteLine("In your sentence there where {0} vowels", TotalVowels);
            Console.WriteLine("{0} of these where an \"a\"", TotalA);
            Console.WriteLine("{0} of these where an \"e\"", TotalE);
            Console.WriteLine("{0} of these where an \"i\"", TotalI);
            Console.WriteLine("{0} of these where an \"o\"", TotalO);
            Console.WriteLine("{0} of these where an \"u\"", TotalU);
        }
    }
}
