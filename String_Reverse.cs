using System;
using System.Collections.Generic;
using System.Text;

namespace Small_projects
{
    public class String_Reverse
    {
        public static void Reverse ()
        {
            //Console.WriteLine("hello");

            string OriginalString = Console.ReadLine();
            char[] StringArray = OriginalString.ToCharArray();
            string ReversedString = String.Empty;
            for (int i = StringArray.Length-1; i >= 0; i--)
            {
                ReversedString += StringArray[i];
            }

            Console.WriteLine("Reveresed string: " + ReversedString);
        }
    }
}
