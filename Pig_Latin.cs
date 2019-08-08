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
            string PigLatinString = OriginalString.Substring(1);
            PigLatinString += "-" + OriginalString[0] + "ay";
            Console.WriteLine("Pig latin string: " + PigLatinString);
        }
    }
}
