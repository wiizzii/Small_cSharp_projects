using System;
using System.Collections.Generic;
using System.Text;

namespace Small_projects
{
    public class String_Reverse
    {
        public static void Reverse ()
        {
            string OriginalString = Console.ReadLine();
            char[] ReversedString = OriginalString.ToCharArray();
            Array.Reverse(ReversedString);
            Console.WriteLine("Reveresed string: " +  new string(ReversedString));
        }
    }
}
