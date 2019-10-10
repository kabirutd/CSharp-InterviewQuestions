using System;

namespace AnagramStrings
{
    public class AnagramStringsClass
    {
        public static void Main(string[] args)
        {
            string word1 = "Stop";

            string word2 = "Spot";

            AnagramClass anagramClass = new AnagramClass();

            Console.WriteLine(anagramClass.IsAnagram2(word1, word2));

        }

        public  string IsAnagram(string word1, string word2)
        {

            char[] charArray1 = word1.ToLower().ToCharArray();
            Array.Sort(charArray1);

            char[] charArray2 = word2.ToLower().ToCharArray();
            Array.Sort(charArray2);

            string newString1 = new string(charArray1);
            string newString2 = new string(charArray2);

            return (word1 + " and " + word2 + " are " + (newString1 == newString2 ? "Anagram" : "Not Anagram"));

        }

        /*
         
        //Javascript:
        function bool isAnagram(str1, str2)
        {

        return (str1.split('').sort().join('') === str2.split('').sort().join('') ? true: false );

        }
         * */

    }
}
