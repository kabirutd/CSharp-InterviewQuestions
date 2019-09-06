using System;

namespace RemoveDupChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "Google", "Jamais", "Mother", "durikka lala" };

            foreach (string str in strArray)
            {
                Console.WriteLine(str + " after removing dups " + RemoveDupChars(str.ToLower()));
            }
        }

        static string RemoveDupChars(string str)
        {
            string mainString = "";
            string updatedString = "";

            foreach (char c in str )
            {
                if (mainString.IndexOf(c) == -1)
                {
                    mainString += c;
                    updatedString += c;
                }
            }
            return updatedString;
        }
    }
}
