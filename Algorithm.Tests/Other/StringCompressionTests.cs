using Algorithm.Other.StringCompression;

namespace Algorithm.Tests.Other;

public class StringCompressionTests
{
    [Fact]
    public void WithOneSingleChar()
    {
        Assert.Equal("a", StringCompression.Run("a"));
    }

    [Fact]
    public void WithTwoChars()
    {
        Assert.Equal("aa", StringCompression.Run("aa"));
    }

    [Fact]
    public void WithThreeChars()
    {
        Assert.Equal("3a", StringCompression.Run("aaa"));
    }

    [Fact]
    public void WithDifferentChars()
    {
        Assert.Equal("aaab", StringCompression.Run("aaab"));
    }

    [Fact]
    public void WithDifferentChars_RepeatingSeveralTimes()
    {
        Assert.Equal("3a2b", StringCompression.Run("aaabb"));
    }

    [Fact]
    public void WithDifferentChars_RepeatingInMoreSeqs()
    {
        Assert.Equal("3a2b2a", StringCompression.Run("aaabbaa"));
    }
}