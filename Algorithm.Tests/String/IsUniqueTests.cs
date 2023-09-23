using Algorithm.String.IsUnique;

namespace Algorithm.Tests.String;

public class IsUniqueTest
{
    [Theory]
    [InlineData("abc", true)]
    [InlineData("aabc", false)]
    [InlineData("", true)]
    [InlineData("a", true)]
    [InlineData("abcdef", true)]
    [InlineData("abcdea", false)]
    [InlineData("123456", true)]
    [InlineData("1123456", false)]
    [InlineData("  ", false)]
    [InlineData(" ", true)]
    [InlineData("a A", true)]
    [InlineData("aA", true)]
    [InlineData("!!", false)]
    [InlineData("!@", true)]
    [InlineData("abcdefghijklmnopqrstuvwxyz", true)]
    [InlineData("abcdefghijklmnopqrstuvwxyzA", true)]
    public void Run_ShouldReturnExpectedResults(string input, bool expected)
    {
        // Act
        var result = IsUnique.RunWithBitManipulation(input);

        // Assert
        Assert.Equal(expected, result);
    }
}