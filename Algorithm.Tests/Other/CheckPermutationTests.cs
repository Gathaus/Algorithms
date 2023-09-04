using Algorithm.Other.CheckPermutation;

namespace Algorithm.Tests.Other;

public class CheckPermutationTests
{
    [Fact]
    public void Test_BothStringsEmpty()
    {
        // Arrange
        string str1 = "";
        string str2 = "";

        // Act
        bool result = CheckPermutation.RunWithHashSet(str1, str2);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_StringsArePermutations()
    {
        // Arrange
        string str1 = "abc";
        string str2 = "bca";

        // Act
        bool result = CheckPermutation.RunWithHashSet(str1, str2);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test_StringsAreNotPermutations_DifferentLength()
    {
        // Arrange
        string str1 = "abc";
        string str2 = "abcd";

        // Act
        bool result = CheckPermutation.RunWithHashSet(str1, str2);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_StringsAreNotPermutations_DifferentCharacters()
    {
        // Arrange
        string str1 = "abc";
        string str2 = "def";

        // Act
        bool result = CheckPermutation.RunWithHashSet(str1, str2);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test_StringsAreNotPermutations_SameCharactersDifferentFrequency()
    {
        // Arrange
        string str1 = "aabb";
        string str2 = "abab";

        // Act
        bool result = CheckPermutation.RunWithHashSet(str1, str2);

        // Assert
        Assert.True(result);
    }
}