namespace Algorithm.Sorting;

public class MergeSort : ISortAlgorithm
{
    public T[] Sort<T>(T[] arr) where T : IComparable<T>
    {

        for(int i = 1; i<arr.Length; i++){
            T key = arr[i];
            int j = i - 1;

            while(j >= 0 && arr[j].CompareTo(key) > 0){
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;

        }

        return arr;
    }
}