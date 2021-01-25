using System;
using System.Collections.Generic; // Used for lists

namespace Create_List
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 'Names' list

            var Names = new List<string> {
                "Zoe", "Rina", "Tali"
            };

            // Show every item from list

            foreach(var name in Names) {
                Console.WriteLine($"Welcome {name.ToUpper()}!");
            }

            // Add && Remove components from list

            Console.WriteLine();
            Names.Add("Lore");
            Names.Remove("Tali");
            foreach(var name in Names) {
                Console.WriteLine($"Welcome {name.ToUpper()}!");
            }

            // Indexing

            Console.WriteLine();
            Console.WriteLine(Names[0]);

            // 'Count' method

            Console.WriteLine();
            Console.WriteLine(Names.Count);

            // 'IndexOf' method
            // 'IndexOf' returns '-1' if the index is not found

            Console.WriteLine();
            var indexRina = Names.IndexOf("Rina");
            if(indexRina != -1) // Found
                Console.WriteLine($"The index of 'Rina' is {indexRina}.");
            else
                Console.WriteLine("Didn't found the index.");

            // 'Sort' method
            // 'Sort' sorts the list in alphabetical order for strings

            Console.WriteLine();
            Names.Sort();
            foreach(var name in Names) {
                Console.WriteLine($"{name}");
            }

            // Lists of ints

            Console.WriteLine();
            var fibonacciNums = new List<int> {
                1, 1
            };
            fibonacciNums.Add(fibonacciNums[0] + fibonacciNums[1]);
            foreach (var Nums in fibonacciNums) {
                Console.WriteLine(Nums);
            }

            // Challenge
            /*
            First 20 nums in fibonacci
            */

            fibonacciNums.Remove(fibonacciNums[2]);
            Console.WriteLine();
            for (int i = 1; i <= 18; i++)
                fibonacciNums.Add(fibonacciNums[i] + fibonacciNums[i - 1]);

            foreach (var Nums in fibonacciNums) {
                Console.WriteLine(Nums);
            }

            // Method 2:
            
            /*
            var fibonacciNumbers = new List<int> {1, 1};
            while (fibonacciNumbers.Count < 20) {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach(var item in fibonacciNumbers)
                Console.WriteLine(item);

                -
                Exp: Iei pe indecsi.
                -
                
            */
        }
    }
}
