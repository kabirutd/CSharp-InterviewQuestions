using System;
using System.Linq;
namespace Palindrome
{

}
public class Program
{
     static void Main()
    {
        
        string[] strArray = { "Bob", "Jamais", "Mom", "radar"  };
       
        foreach (string str in strArray)
        {
            //Console.WriteLine(str.ToLower() + " is " + IsPalindrome(str.ToLower()));
            Console.WriteLine(str.ToLower() + " is " + IsPalindromeInOneLine(str.ToLower()));
        }
    }

    static string IsPalindrome (string str)
    { 
        //this is wothout LINQ
        char[] rev = str.ToLower().ToCharArray();
        Array.Reverse(rev);
        string revs = new string(rev);
        return str.Equals(revs) ? "Palindrome" : "Not Palindrome";
       
    }

    static string IsPalindromeInOneLine(string str)
    {
        
        return str.Equals(new string(str.ToLower().ToCharArray().Reverse().ToArray() )   ) ? "Palindrome" : "Not Palindrome";

    }
}
