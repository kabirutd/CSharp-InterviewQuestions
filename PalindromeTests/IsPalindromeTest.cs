using System;
using Xunit;
using Palindrome;

namespace PalindromeTests
{
    public class IsPalindromeTest
    {
        [Theory]
        [InlineData("bob", "Palindrome")]
        [InlineData("Tim", "Not Palindrome")]
        [InlineData("mom", "Palindrome")]
        [InlineData("Jamais", "Not Palindrome")]
        [InlineData("BoB", "Palindrome")]
        [InlineData("Bob", "Palindrome")]
        [InlineData("Mom", "Palindrome")]
        [InlineData("MoM", "Palindrome")]
        public void IsPalindrome_ShouldCheck(string str,  string expectedResult)
        {
            // Arrange
             PalinDromeClass palindrome = new PalinDromeClass();

            // Act
            string actualResult = palindrome.IsPalindrome(str);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
