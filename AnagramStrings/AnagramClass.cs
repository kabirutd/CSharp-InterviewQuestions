using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramStrings
{
    public class AnagramClass
    {

        public string IsAnagram2(string word1, string word2)
        {

            char[] charArray1 = word1.ToLower().ToCharArray();
            Array.Sort(charArray1);

            char[] charArray2 = word2.ToLower().ToCharArray();
            Array.Sort(charArray2);

            string newString1 = new string(charArray1);
            string newString2 = new string(charArray2);

            return (word1 + " and " + word2 + " are " + (newString1 == newString2 ? "Anagram" : "Not Anagram"));

        }
    }
}
