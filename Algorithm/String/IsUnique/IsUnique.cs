using Algorithm.Sorting;

namespace Algorithm.String.IsUnique;
//Cracking Coding Interview 1.1
public class IsUnique
{
    public bool RunWithSorting(string str)
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

    public bool RunWithHashSet(string str)
    {
        
        HashSet<char> charSet = new HashSet<char>();

        foreach(char c in str){
            if(charSet.Contains(c))
                return false;

            charSet.Add(c);
        }
        return true;
    }

    public static bool RunWithBitManipulation(string str)
    {
        long bitVector = 0;

        foreach (char c in str)
        {
            int bitIndex = (int) c;
            long mask = 1L << bitIndex;

            if ((bitVector & mask) != 0)
                return false;
            bitVector = bitVector | mask;
        }

        return true;
    }

}