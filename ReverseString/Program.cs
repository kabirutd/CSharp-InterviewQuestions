using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string and hit enter to reverse: ");
            string str = Console.ReadLine().ToString();
            Console.WriteLine(DoReverseString(str));

        }

        static string DoReverseString(string str)
        {

            return new string(str.ToCharArray().Reverse().ToArray());
            
        }
    }
}
