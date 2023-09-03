using Algorithm.Sorting;

namespace Algorithm.Other.IsUnique;

public class IsUnique
{
    public static bool RunWithSorting(string str)
    {
        char[] charArray = str.ToCharArray();
        
        var mergeSort = new MergeSort();
        var sortedArr = mergeSort.Sort(charArray);
        string sortedStr = new string(sortedArr);

        for (int i = 0; i < sortedStr.Length - 1; i++)
        {
            if (sortedStr[i] == sortedStr[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    public static bool RunWithHashSet(string str)
    {
        
        HashSet<char> charSet = new HashSet<char>();

        foreach(char c in str){
            if(charSet.Contains(c))
                return false;

            charSet.Add(c);
        }
        return true;
    }

}