using Algorithm.String.StringRotation;

namespace Algorithm.Tests.String;

public class StringRotationTests
{

    [Fact]
    public void WithEmpty()
    {
        Assert.True(StringRotation.Run("", ""));
    }

    [Fact]
    public void WithSameWord()
    {
        Assert.True(StringRotation.Run("hello", "hello"));
    }

    [Fact]
    public void WithRotated()
    {
        Assert.True(StringRotation.Run("hello", "llohe"));
    }

    [Fact]
    public void WithSubstring_ButDifferentSize()
    {
        Assert.False(StringRotation.Run("hello", "llo"));
    }

    [Fact]
    public void WithDifferentWords()
    {
        Assert.False(StringRotation.Run("hello", "world"));
    }

    [Fact]
    public void WithNotRotated()
    {
        Assert.False(StringRotation.Run("hello", "oehll"));
    }
}