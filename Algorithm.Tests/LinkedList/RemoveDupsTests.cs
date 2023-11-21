using Xunit;
using Algorithm.Data_Structures.LinkedList;
using Algorithm.LinkedLists;

public class RemoveDupsTests
{
    [Fact]
    public void Test_EmptyList()
    {
        var list = new SinglyLinkedList<int>();
        var result = RemoveDups.Run(list);

        Assert.Null(result.Head);
    }

    [Fact]
    public void Test_SingleElementList()
    {
        var list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        var result = RemoveDups.Run(list);

        Assert.Equal(1, result.Head.Data);
    }

    [Fact]
    public void Test_NoDuplicates()
    {
        var list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        var result = RemoveDups.Run(list);

        Assert.Equal(3, result.Head.Data);
        Assert.Equal(2, result.Head.Next.Data);
        Assert.Equal(1, result.Head.Next.Next.Data);
    }

    [Fact]
    public void Test_WithDuplicates()
    {
        var list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(1);
        list.AddFirst(3);
        list.AddFirst(2);
        var result = RemoveDups.Run(list);

        Assert.Equal(2, result.Head.Data);
        Assert.Equal(3, result.Head.Next.Data);
        Assert.Equal(1, result.Head.Next.Next.Data);
        Assert.Null(result.Head.Next.Next.Next);
        
        
    }
    
    
    [Fact]
    public void Test_EmptyList_WithoutBuffer()
    {
        var list = new SinglyLinkedList<int>();
        var result = RemoveDups.RunWithoutBuffer(list);

        Assert.Null(result.Head);
    }

    [Fact]
    public void Test_SingleElementList_WithoutBuffer()
    {
        var list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        var result = RemoveDups.RunWithoutBuffer(list);

        Assert.Equal(1, result.Head.Data);
    }

    [Fact]
    public void Test_NoDuplicates_WithoutBuffer()
    {
        var list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        var result = RemoveDups.RunWithoutBuffer(list);

        Assert.Equal(3, result.Head.Data);
        Assert.Equal(2, result.Head.Next.Data);
        Assert.Equal(1, result.Head.Next.Next.Data);
    }

    [Fact]
    public void Test_WithDuplicates_WithoutBuffer()
    {
        var list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(1);
        list.AddFirst(3);
        list.AddFirst(2);
        var result = RemoveDups.RunWithoutBuffer(list);
    
        // Listenin beklenen son halini kontrol ediyoruz: 2 -> 3 -> 1
        Assert.Equal(2, result.Head.Data);
        Assert.Equal(3, result.Head.Next.Data);
        Assert.Equal(1, result.Head.Next.Next.Data);
        Assert.Null(result.Head.Next.Next.Next); // Listenin bu noktadan sonra sona ermesi gerekiyor
    }

}