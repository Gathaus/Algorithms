namespace Algorithm.Data_Structures.LinkedList;

public class SinglyLinkedList<T>
{   
    public Node<T> Head { get; set; }
    public Node<T> Tail { get; set; }

    public void AddFirst(T value)
    {
        var newNode = new Node<T>(value);

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
    
        }
    }

    public void RemoveFirst()
    {
        if(Head == null)
            return;

        Head = Head.Next;
    }

    public void RemoveLast()
    {
        if (Head == null)
            return;

        if (Head == Tail)
        {
            Head = null;
            Tail = null;
            return;
        }

        var previous = Head;
        while (previous.Next != Tail)
        {
            previous = previous.Next;
        }

        Tail = previous;
        Tail.Next = null;

    }
    public void AddLast(T value)
    {
        var newNode = new Node<T>(value);

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
    }
    
    
}

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
    }

    public override string ToString() => $"Data: {Data}";
}


