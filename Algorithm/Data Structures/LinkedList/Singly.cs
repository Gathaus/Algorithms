namespace Algorithm.Data_Structures.LinkedList;

public class SinglyLinkedList<T>
{   
    public Node<T> Head {get;set;}
    public Node<T> Tail {get;set;}

    public void AddFirst(T node)
    {
        var node = new Node<T>(node);

        node.Next = Head;
        Head = node;

        if(Tail == null)
            Tail = Head;

    }

    public void AddLast(T node)
    {
        var node = new Node<T>(node);

        if(Head is null){
            Head = node;
            Tail = node;
        }
        else{
            Tail.Next = node;
            Tail = node;

        }

    }
    
}

public class Node<T>
{
    public T Data {get; set;}
    public Node<T> Next {get; set;}

    public Node(T data){
        Data = data;
    }

    public override string ToString() => $"Data: {data}";
}