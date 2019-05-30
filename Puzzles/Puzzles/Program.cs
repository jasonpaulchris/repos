using System;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the nth vaue as integer: ");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Loop calculation: Factorial of {n} is {CalculateLoop(n)}");
        }

        private static int CalculateLoop(int n)
        {
            var factorial = 1;
            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
