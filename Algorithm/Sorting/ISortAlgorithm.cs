namespace Algorithm.Sorting;

public interface ISortAlgorithm
{
    public T[] Sort<T>(T[] arr) where T : IComparable<T>;
}