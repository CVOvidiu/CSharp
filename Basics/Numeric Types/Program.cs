using System;

namespace Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic integer math

            int a = 11; // Intreg
            int b = 6; // Intreg
            int sum = a + b; // Suma
            int subtract = a - b; // Diferenta
            int multiply = a * b; // Inmultire
            int division = a / b; // Cat
            int modulus = a % b; // Rest
            Console.WriteLine(sum);
            Console.WriteLine(subtract);
            Console.WriteLine(multiply);
            Console.WriteLine(division);
            Console.WriteLine(modulus);

            // Basic float math

            float c = 6f; // Real
            float d = 7f; // Real
            double e = 6; // Real v 2.0
            double f = 7; // Real v 2.0
            decimal g = 6M;
            decimal h = 7M;
            Console.WriteLine(c / d); // Impartire zecimala
            Console.WriteLine(e / f);
            Console.WriteLine(g / h);

            /*
            Challenge:
                Write code that calculates 
                the area of a circle whose radius is 2.50 centimeters.
            */
            double radius = 2.50;
            double ans = Math.PI * radius * radius;
            Console.WriteLine($"Ans : {ans}");

        }
    }
}
