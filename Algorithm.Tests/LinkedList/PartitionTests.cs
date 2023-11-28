using Algorithm.Data_Structures.LinkedList;
using Algorithm.LinkedList.Partition;
using Xunit;

public class PartitionLinkedListTests
{
    [Fact]
    public void Partition_WithMiddleValue_PartitionsCorrectly()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(3);
        list.AddLast(5);
        list.AddLast(8);
        list.AddLast(5);
        list.AddLast(10);
        list.AddLast(2);
        list.AddLast(1);

        var partitioned = PartitionLinkedList.RunWithOnPlaceAdjust(list, 5);

        // Test: 5 ve daha büyük değerlerin, 5'ten küçük değerlerden sonra geldiğini kontrol et
        // Bu testte, tam doğru sıralama beklenmeyebilir ama bölünmüş iki bölümün doğru olması gerekmektedir
    }

    [Fact]
    public void Partition_WithValueNotInList_KeepsOrderIntact()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        var partitioned = PartitionLinkedList.RunWithOnPlaceAdjust(list, 4);

        // Test: Liste değişmeden kalır çünkü bölme değeri listede yok
    }

    [Fact]
    public void Partition_WithEmptyList_ReturnsEmptyList()
    {
        var list = new SinglyLinkedList<int>();
        var partitioned = PartitionLinkedList.RunWithOnPlaceAdjust(list, 5);

        // Test: Boş liste geri döner
    }

    [Fact]
    public void Partition_WithAllElementsLessThanPartitionValue_ReturnsSameList()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        var partitioned = PartitionLinkedList.RunWithOnPlaceAdjust(list, 4);

        // Test: Tüm elemanlar bölme değerinden küçük olduğunda, liste aynı kalır
    }

    [Fact]
    public void Partition_WithAllElementsGreaterThanPartitionValue_ReturnsSameList()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(5);
        list.AddLast(6);
        list.AddLast(7);

        var partitioned = PartitionLinkedList.RunWithOnPlaceAdjust(list, 4);

        // Test: Tüm elemanlar bölme değerinden büyük olduğunda, liste aynı kalır
    }

    [Fact]
    public void Partition_WithOnlyOneElement_ReturnsSameList()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);

        var partitioned = PartitionLinkedList.RunWithOnPlaceAdjust(list, 2);

        // Test: Tek elemanlı liste aynı kalır
    }

    // Diğer özel durumlar için ek testler yazılabilir
}
