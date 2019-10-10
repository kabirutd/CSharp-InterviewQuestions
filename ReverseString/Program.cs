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

        //javascript uisng reduce
        //function reverse(str)
        //{
        //    return str.split('').reduce((rev, char) => char + rev, '');
        //}

        //javascript with reverse function
        //function reverse(str)
        //{
        //    return str
        //      .split('')
        //      .reverse()
        //      .join('');
        //}

        //javascript with no reverse keyword
        //function reverse(str)
        //{
        //    let reversed = '';

        //    for (let character of str)
        //    {
        //        reversed = character + reversed;
        //    }

        //    return reversed;
        //}

    }
}
