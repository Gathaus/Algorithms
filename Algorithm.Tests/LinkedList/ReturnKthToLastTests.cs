using Xunit;
using Algorithm.Data_Structures.LinkedList;
using Algorithm.LinkedList.ReturnKthToLast;

public class ReturnKthToLastTests {
    [Fact]
    public void TestWithNormalList() {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        list.AddLast(4);
        list.AddLast(5);

        Assert.Equal(3, ReturnKthToLast.RunWithRecursive(list, 3));
    }

    [Fact]
    public void TestWithKGreaterThanListLength() {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);

        Assert.Throws<Exception>(() => ReturnKthToLast.RunWithRecursive(list, 2));
    }

    [Fact]
    public void TestWithEmptyList() {
        var list = new SinglyLinkedList<int>();

        Assert.Throws<Exception>(() => ReturnKthToLast.RunWithRecursive(list, 1));
    }
}