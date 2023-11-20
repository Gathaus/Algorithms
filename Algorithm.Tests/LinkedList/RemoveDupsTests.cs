using Xunit;
using System.Collections.Generic;
using Algorithm.LinkedLists;

public class RemoveDupsTests
{
    [Fact]
    public void Test_EmptyList()
    {
        var list = new LinkedList<int>();
        var result = RemoveDups.Run(list);
        Assert.Empty(result);
    }

    [Fact]
    public void Test_NoDuplicates()
    {
        var list = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        var result = RemoveDups.Run(list);
        Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, result);
    }

    [Fact]
    public void Test_WithDuplicates()
    {
        var list = new LinkedList<int>(new int[] { 1, 2, 2, 3, 4, 4, 5, 5 });
        var result = RemoveDups.Run(list);
        Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, result);
    }

    [Fact]
    public void Test_AllDuplicates()
    {
        var list = new LinkedList<int>(new int[] { 1, 1, 1, 1 });
        var result = RemoveDups.Run(list);
        Assert.Equal(new int[] { 1 }, result);
    }

    [Fact]
    public void Test_SingleElement()
    {
        var list = new LinkedList<int>(new int[] { 1 });
        var result = RemoveDups.Run(list);
        Assert.Equal(new int[] { 1 }, result);
    }
}