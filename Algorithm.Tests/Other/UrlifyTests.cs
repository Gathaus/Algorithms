using Algorithm.Other.URLify;
using Xunit;

public class URLifyTests
{
    [Fact]
    public void Test_ReplaceSpaces_WithNormalInput_ShouldReturnCorrectOutput()
    {
        string input = "Mr John Smith    ";
        char[] inputArr = input.ToCharArray();
        inputArr = Urlify.RunWithIterative(inputArr, 13);

        string result = new string(inputArr).TrimEnd('\0');
        Assert.Equal("Mr%20John%20Smith", result);
    }

    [Fact]
    public void Test_ReplaceSpaces_WithSpacesBetweenTwoChars_ShouldReturnCorrectOutput()
    {
        string input = "A B  ";
        char[] inputArr = input.ToCharArray();
        inputArr = Urlify.RunWithIterative(inputArr, 3);

        string result = new string(inputArr).TrimEnd('\0');
        Assert.Equal("A%20B", result);
    }

    [Fact]
    public void Test_ReplaceSpaces_WithNoSpaces_ShouldReturnOriginalString()
    {
        string input = "NoSpace";
        char[] inputArr = input.ToCharArray();
        inputArr = Urlify.RunWithIterative(inputArr, 7);

        string result = new string(inputArr).TrimEnd('\0');
        Assert.Equal("NoSpace", result);
    }

    [Fact]
    public void Test_ReplaceSpaces_WithOnlyOneSpace_ShouldReturnPercent20()
    {
        string input = "   ";
        char[] inputArr = input.ToCharArray();
        inputArr = Urlify.RunWithIterative(inputArr, 1);

        string result = new string(inputArr).TrimEnd('\0');
        Assert.Equal("%20", result);
    }


    [Fact]
    public void Test_ReplaceSpaces_WithEmptyString_ShouldReturnEmptyString()
    {
        string input = "";
        char[] inputArr = input.ToCharArray();
        inputArr = Urlify.RunWithIterative(inputArr, 0);

        string result = new string(inputArr).TrimEnd('\0');
        Assert.Equal("", result);
    }


    // The ReplaceSpaces method from above goes here for compilation.
}


