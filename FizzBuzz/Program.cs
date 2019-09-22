using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Range for showing FizzBuzz: ");
            int input = int.Parse(Console.ReadLine().ToString());

            for (var i=1; i<=input; i++)
            {
                Console.WriteLine(GetFizzBuzz(i));
            }
        }

        static string GetFizzBuzz(int num)
        {
            return $"{(num%15==0 ?"FizzBuzz": (num%3==0 ? "Fizz": (num%5==0 ? "Buzz": num.ToString() ) ) )}";
        }
    }
}
