using System;

namespace Basic_String_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basics

            string myString = "Ovidiu";
            Console.WriteLine(myString);
            Console.WriteLine("Hello, " + myString);
            Console.WriteLine($"Hello, {myString}");

            // Concatenate

            string firstString = "What's up";
            string secondString = "Boio";
            Console.WriteLine($"My strings are {firstString} and {secondString}.");

            // String length

            Console.WriteLine($"firstString has {firstString.Length} characters.");

            // Trimming

            string thirdString = "   Boi with spaces     ";
            Console.WriteLine($"[{thirdString}]");
            Console.WriteLine($"[{thirdString.TrimStart()}]");
            Console.WriteLine($"[{thirdString.TrimEnd()}]");
            Console.WriteLine($"[{thirdString.Trim()}]");

            // Replace sequence

            string forthString = "Ay, boio";
            Console.WriteLine(forthString);
            forthString = forthString.Replace("Ay", "Oi");
            Console.WriteLine(forthString);

            // Upper && Lower

            string fifthString = "Seriously?";
            Console.WriteLine(fifthString.ToUpper());
            Console.WriteLine(fifthString.ToLower());

            // Contain

            string sixthString = "Reee boi";
            Console.WriteLine($"Contine 'Reee'? : {sixthString.Contains("Reee")}");
            Console.WriteLine($"Contine 'y'? : {sixthString.Contains("y")}");

            // Sufix && Prefix

            string seventhString = "razbunare";
            Console.WriteLine($"Are sufix 'raz'? : {seventhString.StartsWith("raz")}");
            Console.WriteLine($"Are prefix 'yikez'? : {seventhString.EndsWith("yikez")}");
        }
    }
}
