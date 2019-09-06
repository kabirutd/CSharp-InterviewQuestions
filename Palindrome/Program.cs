using System;
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
            Console.WriteLine(str.ToLower() + " is " + IsPalindrome(str.ToLower()));
        }
    }

    static string IsPalindrome (string str)
    { 
        char[] rev = str.ToLower().ToCharArray();
        Array.Reverse(rev);
        string revs = new string(rev);
        return str.Equals(revs) ? "Palindrome" : "Not Palindrome";
       
    }
}
