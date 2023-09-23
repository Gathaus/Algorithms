namespace Algorithm.String.PalindromePermutation;

//Cracking Coding Interview 1.4

public static class PalindromePermutation
{
    public static bool RunWithDictionary(string input)
    {
        var dict = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            char lowerChar = Char.ToLower(input[i]);
            if (Char.IsWhiteSpace(lowerChar))
                continue;

            if (dict.ContainsKey(lowerChar))
                dict[lowerChar]++;
            else
                dict.Add(lowerChar, 1);
        }

        int oddNumberCount = 0;
        foreach (var entry in dict)
        {
            if (entry.Value % 2 != 0)
                oddNumberCount++;

            if (oddNumberCount > 1)
                return false;
        }

        return true;
    }
    
    
    public static bool RunWithHashSet(string str)
    {
        HashSet<char> hashSet = new HashSet<char>();
    
        foreach(char ch in str)
        {
            char lowerChar = char.ToLower(ch);
        
            if(char.IsWhiteSpace(lowerChar)) 
                continue;

            if (hashSet.Contains(lowerChar))
                hashSet.Remove(lowerChar);
            else
                hashSet.Add(lowerChar);
        }
    
        if(hashSet.Count>1)
            return false;
        else
            return true;
    }

    //need more work on this to understand
    public static bool RunWithBitVector(string str)
    {
        int bitVector = 0;

        foreach (char c in str)
        {
            char lowerChar = char.ToLower(c);
            if (char.IsWhiteSpace(lowerChar))
                continue;

            int index = lowerChar - 'a'; 

            int mask = 1 << index;
            if ((bitVector & mask) == 0)
                bitVector =bitVector | mask;  
            else
                bitVector = bitVector &  ~mask;
        }

        return bitVector == 0 || (bitVector & (bitVector - 1)) == 0;
    }

    
}
