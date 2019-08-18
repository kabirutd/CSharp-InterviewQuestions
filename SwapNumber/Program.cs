using System;

namespace SwapNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 3;

            Console.WriteLine($"First Number before swapping: {num1}");
            Console.WriteLine($"Second Number before swapping: {num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"First Number after swapping: {num1}");
            Console.WriteLine($"Second Number after swapping: {num2}");
        }

    
    }
}
