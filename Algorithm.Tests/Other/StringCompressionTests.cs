using Algorithm.Other.StringCompression;

namespace Algorithm.Tests.Other;

public class StringCompressionTests
{
    [Theory]
    [InlineData("aabcccccaaa", "a2b1c5a3")]
    [InlineData("abcd", "abcd")]
    [InlineData("aabbcc", "aabbcc")]
    [InlineData("a", "a")]
    [InlineData("aa", "aa")]
    [InlineData("aaa", "a3")]
    [InlineData("", "")]
    public void TestCompressString(string input, string expected)
    {
        var result = StringCompression.Run(input);
        Assert.Equal(expected, result);
    }
}