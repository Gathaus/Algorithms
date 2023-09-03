// ReSharper disable SwapViaDeconstruction
namespace Algorithm.Sorting;

public class SelectionSort : ISortAlgorithm
{
    public T[] Sort<T>(T[] arr) where T : IComparable<T>
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j].CompareTo(arr[minIndex]) < 0)
                    minIndex = j;
            }

            T temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        return arr;
    }
}