namespace Algorithm.Sorting;
// ReSharper disable once SwapViaDeconstruction

public class BubbleSort : ISortAlgorithm
{
    public T[] Sort<T>(T[] arr) where T : IComparable<T>
    {
        int arrLength = arr.Length;

        for (int pass = 0; pass < arrLength - 1; pass++)
        {
            for (int index = 0; index < arrLength - pass - 1; index++)
            {
                if (arr[index].CompareTo(arr[index + 1]) > 0)
                {
                    T temp = arr[index + 1];
                    arr[index + 1] = arr[index];
                    arr[index] = temp;
                }
            }
        }

        return arr;
    }
}