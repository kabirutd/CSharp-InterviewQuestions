using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    public class PalindromeChecker : IPalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            var loweredLettersAndNumbers = input
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLower);

            if (!loweredLettersAndNumbers.Any())
            {
                // we need letters or numbers to qualify as a palindrome
                return false;
            }

            // do the reversed characters match? if so, we have a palindrome.
            return loweredLettersAndNumbers
                .Reverse()
                .SequenceEqual(loweredLettersAndNumbers);
        }
    }
}
