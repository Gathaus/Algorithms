using Algorithm.Other.OneAway;

namespace Algorithm.Tests.Other;

public class OneAwayTests
{
    public class _01_05_OneAwayTests
    {
        public class OneAwayTest
        {
            [Fact]
            public void WithEmpty()
            {
                Assert.True(OneAway.Run("", ""));
            }

            [Fact]
            public void WithOneEmpty()
            {
                Assert.True(OneAway.Run("", "b"));
            }

            [Fact]
            public void WithTwoSingleWords()
            {
                Assert.True(OneAway.Run("a", "b"));
            }

            [Fact]
            public void WithOneInsertion()
            {
                Assert.True(OneAway.Run("pae", "pale"));
            }

            [Fact]
            public void WithOneDeletion()
            {
                Assert.True(OneAway.Run("pales", "paes"));
            }

            [Fact]
            public void WithOneReplace()
            {
                Assert.True(OneAway.Run("pawe", "pave"));
            }

            [Fact]
            public void WithMoreEdits()
            {
                Assert.False(OneAway.Run("paxye", "pamne"));
            }
        }
    }
}