using Algorithm.Data_Structures.LinkedList;

namespace Algorithm.LinkedLists;

public static class RemoveDups
{
    public static SinglyLinkedList<T> Run<T>(SinglyLinkedList<T> list)
    {
        if (list.Head == null || list.Head.Next == null)
            return list;

        list.PrintList();
        
        Node<T> node = list.Head;
        var hashSet = new HashSet<T>(){node.Data};

        while(node.Next != null){

            if(hashSet.Contains(node.Next.Data)){
                node.Next = node.Next.Next;
            }
            else{
                hashSet.Add(node.Next.Data);
                node = node.Next;
            }
        }

        list.PrintList();

        return list;


    }


    public static SinglyLinkedList<T> RunWithoutBuffer<T>(SinglyLinkedList<T> list)
    {
        if(list.Head == null || list.Head.Next == null)
            return list; 
        
        Node<T> current = list.Head;
        list.PrintList();

        while(current != null){
            
            Node<T> runner = current;

            while(runner.Next != null){
                
                if(Equals(runner.Next.Data,current.Data))
                    runner.Next = runner.Next.Next;
                else
                    runner = runner.Next;
            }

            current = current.Next;
        }
        
        list.PrintList();


        return list;
    }
}
