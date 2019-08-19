using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0, val2 = 1, val3, i, n;

            n = 10;

            Console.WriteLine($"Fibonacci series of first {n} numbers:");
            Console.Write(val1 + " " + val2 + " ");

            for (i = 2; i < n; ++i)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }

        }

        static int GetFibonacciNumbers(int num)
        {

            int firstNumber = 0;
            int secondNumber = 1;
            int result = 0;

            if (num == 0)  return 0;
            if  (num == 1) return 1;

            for (int i=2; i<num; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }

            return result;

        }
    }
}
