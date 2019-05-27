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
            Console.WriteLine(resultString);
        }
    }
}
