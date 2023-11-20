using Algorithm.String.PalindromePermutation;

namespace Algorithm.Tests.String;

    public class PalindromePermutationTest
    {

        [Fact]
        public void WithEmpty()
        {
            Assert.True(PalindromePermutation.RunWithHashSet(""));
        }

        [Fact]
        public void WithOneChar()
        {
            Assert.True(PalindromePermutation.RunWithHashSet("a"));
        }

        [Fact]
        public void WithTwoWords_OddLetters()
        {
            Assert.True(PalindromePermutation.RunWithHashSet("acto tac"));
        }

        [Fact]
        public void WithTwoWords_OddLetters_ThreeOccurences()
        {
            Assert.True(PalindromePermutation.RunWithHashSet("act atac"));
        }

        [Fact]
        public void WithTwoWords_EvenLetters()
        {
            Assert.True(PalindromePermutation.RunWithHashSet("act cat"));
        }
    }