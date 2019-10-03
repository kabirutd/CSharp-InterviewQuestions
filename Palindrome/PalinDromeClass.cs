using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public class PalinDromeClass
    {

        public string IsPalindrome(string str)
        {
            char[] rev = str.ToLower().ToCharArray();
            Array.Reverse(rev);
            string revs = new string(rev);
            return str.Equals(revs) ? "Palindrome" : "Not Palindrome";

        }
    }
}
