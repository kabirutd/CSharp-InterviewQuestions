using NUnit.Framework;
using AnagramStrings;

namespace AnagramStringsTests
{
    public class AnagramStringsTest
    {
        private AnagramStringsClass _anagramStringsClass = null;
        [SetUp]
        public void Setup()
        {
            _anagramStringsClass = new AnagramStringsClass();
        }

        [TearDown]
        public void CleanUp()
        {
            _anagramStringsClass = null;
           
        }

        
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void AnagramTestStopSpot()
        {
            var word1 = "Stop";
            var word2 = "Spot";
            var expected = word1 + " and " + word2 + " are " + "Anagram";
            var actual = _anagramStringsClass.IsAnagram(word1, word2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnagramTestStopKumod()
        {
            var word1 = "Stop";
            var word2 = "Kumod";
            var expected = word1 + " and " + word2 + " are Not " + "Anagram";
            var actual = _anagramStringsClass.IsAnagram(word1, word2);

            Assert.AreEqual(expected, actual);
        }
    }
}