using Algorithm.Other;
using Algorithm.Other.IsUnique;

namespace Algorithm.Tests.Other;

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
        var result = IsUnique.RunWithSorting(input);

        // Assert
        Assert.Equal(expected, result);
    }
}