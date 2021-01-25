using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write C# code to find the sum of all
             integers 1 through 20 that are divisible by 3.
            */

            int sum = 0;
            for(int i = 1; i <= 20; i++)
                if(i % 3 == 0)
                    sum += i;

            Console.WriteLine(sum);
        }
    }
}
