using System;
using System.Collections.Generic;
using System.Text;

namespace Small_projects
{
    class Pig_Latin
    {
        public static void PigLatin()
        {
            string OriginalString = Console.ReadLine();
            string FirstLetter = OriginalString.Substring(0, 1);
            Console.WriteLine(FirstLetter);
            string PigLatinString = OriginalString.Substring(1);
            Console.WriteLine(PigLatinString);
            PigLatinString += "-" + FirstLetter + "ay";
            Console.WriteLine("Pig latin string: " + PigLatinString);
        }
    }
}
