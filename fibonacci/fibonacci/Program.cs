using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Convert.ToInt32(Console.ReadLine());
            Fibonacci_Iterative(num);
            Fibonacci_Iterative(10);
        }
                
        public static void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.WriteLine("{0} {1}", a, b);

            for (int i = 2; i<len; i++)
            {
                c = a + b;
                Console.WriteLine(" {0}", c);
                a = b;
                b = c;
            }
        }

        public static void Fibonacci_Recursive(int len)
        {
            Fibonacci_Rec_Temp(0, 1, 1, len);
        }

        private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.WriteLine("{0} ", a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }

        public static int GetNthFibonacci_Ite(int n)
        {
            int number = n - 1;
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }

            return Fib[number];
        }
    }
}
