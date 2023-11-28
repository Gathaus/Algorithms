using Algorithm.Data_Structures.LinkedList;

namespace Algorithm.LinkedList.Partition;

public static class PartitionLinkedList
{
    public static SinglyLinkedList<T> Run<T>(SinglyLinkedList<T> list, T partitionValue) where T : IComparable<T>
    {
        // Yeni iki geçici liste oluştur.
        SinglyLinkedList<T> beforePartition = new SinglyLinkedList<T>();
        SinglyLinkedList<T> afterPartition = new SinglyLinkedList<T>();

        // Mevcut listenin her elemanını tek tek kontrol et.
        var currentNode = list.Head;
        while (currentNode != null)
        {
            if (currentNode.Data.CompareTo(partitionValue) < 0)
            {
                // Eğer mevcut düğümün verisi partitionValue'den küçükse, bu düğümü beforePartition listesine ekle.
                beforePartition.AddLast(currentNode.Data);
            }
            else
            {
                // Eğer mevcut düğümün verisi partitionValue'ye eşit veya büyükse, bu düğümü afterPartition listesine ekle.
                afterPartition.AddLast(currentNode.Data);
            }

            // Sonraki düğüme geç.
            currentNode = currentNode.Next;
        }

        // İki listeyi birleştir. Önce beforePartition listesi, sonra afterPartition listesi.
        if (beforePartition.Head == null)
        {
            return afterPartition; // Eğer beforePartition boşsa, sadece afterPartition'ı döndür.
        }

        // beforePartition'ın sonunu afterPartition'ın başına bağla.
        beforePartition.Tail.Next = afterPartition.Head;

        return beforePartition; // Birleştirilmiş listeyi döndür.
    }
    public static SinglyLinkedList<T> RunWithOnPlaceAdjust<T>(SinglyLinkedList<T> list, T partitionValue) where T : IComparable<T>
    {
        if (list.Head == null || list.Head.Next == null)
        {
            return list;
        }

        Node<T> current = list.Head;
        Node<T> lastSmall = null;

        while (current != null)
        {
            if (current.Data.CompareTo(partitionValue) < 0)
            {
                if (lastSmall != current)
                {
                    // Yer değiştirme işlemi
                    T temp = current.Data;
                    current.Data = (lastSmall == null ? list.Head : lastSmall.Next).Data;
                    (lastSmall == null ? list.Head : lastSmall.Next).Data = temp;

                    // lastSmall'ı güncelle
                    lastSmall = lastSmall == null ? list.Head : lastSmall.Next;
                }
            }

            current = current.Next;
        }

        return list;
    }


}