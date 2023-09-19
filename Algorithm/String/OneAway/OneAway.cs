namespace Algorithm.Other.OneAway;

public static class OneAway
{
    public static bool Run(string first, string second)
    {
        if (Math.Abs(first.Length - second.Length) > 1)
        {
            return false;
        }

        int i = 0;
        int j = 0;

        bool foundDifference = false;

        while (i < first.Length && j < second.Length)
        {
            if (first[i] != second[j])
            {
                if (foundDifference)
                {
                    return false;
                }

                foundDifference = true;

                if (first.Length == second.Length)
                {
                    i++;
                    j++;
                }
                else if (first.Length > second.Length)
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            else
            {
                i++;
                j++;
            }
        }

        return true;
    }

}