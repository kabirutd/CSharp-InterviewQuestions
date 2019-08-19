using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Reverse This!";
            Console.WriteLine(DoReverseString(str));
        }

        static string DoReverseString(string str)
        {

            return new string(str.ToCharArray().Reverse().ToArray());
            
        }
    }
}
