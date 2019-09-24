using System;
using System.Linq;
using System.IO;
using System.Collections;

namespace ReverseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter words to reverse:");
            string inputString = Console.ReadLine();

            //string resultString2 = inputString.Split(' ').Reverse();

            //need to memorize sort of
            string resultString = string.Join(' ', inputString
                                        .Split(' ')
                                        .Select(x => new String(x.Reverse().ToArray())));

            //METHOD 2
            //===================================

            //Console.WriteLine(resultString);

            Console.WriteLine($"Reverse of '{inputString}' is '{ReverseString(inputString)}'" );

        }

        static string ReverseString(string str)
        {

            return new string(str.ToCharArray().Reverse().ToArray());
        }



        /*
         JavaScript Code

        function reverseString(str)
        {

            let inputString="one two thre";

            let resultString = resultString.split('')
                                        .reverse()
                                        .join ('');
            return resultString;
         }    
         */
    }
}
