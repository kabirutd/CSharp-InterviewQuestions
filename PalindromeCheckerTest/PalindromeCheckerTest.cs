using Palindrome;
using System;
using Xunit;

namespace PalindromeCheckerTest
{
    public class PalindromeCheckerTests
    {
        [Theory]
        [InlineData("madam", true)]
        [InlineData("nurses run", true)]
        [InlineData("Nurses run", true)]
        [InlineData("nur sesrun", true /*?*/)]  // needs requirements clarification - this is nonsensical, but is it a palindrome?
        [InlineData("Madam, I'm Adam.", true)]  // from https://www.dictionary.com/browse/palindrome
        [InlineData("12321", true)]
        [InlineData("12320", false)]
        [InlineData("a", true)]         // single-letter word
        [InlineData("b", true /*?*/)]   // needs requirements clarification. - While "a" is a single-letter word, "b" is NOT a word by itself so it doesn't really "read" backwords nor forwards according to the definition of palindrome. 
        [InlineData("ab", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(" , ", false)]
        [InlineData("_", false)]        // _ is part of the \w regex character class (https://gist.github.com/antmdvs/b8c77a583284f72eb439c2da0a1c37bb/revisions#diff-7c21bc6041149a1858ff9271bd964b41L21)
        [InlineData(null, false)]       // since we don't have non-nullable reference types (yet) :)
        public void ShouldCorrectlyIdentifyPalindromes(string input, bool expected)
        {
            var sut = new PalindromeChecker();
            var result = sut.IsPalindrome(input);
            Assert.Equal(expected, result);
        }
    }
}
