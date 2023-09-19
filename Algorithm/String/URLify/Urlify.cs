using Algorithm.Sorting;

namespace Algorithm.Other.URLify;

//Cracking Coding Interview 1.3
public static class Urlify
{
    
    //Time Complexity: O(n)
    //Space Complexity: O(1)
    public static char[] RunWithIterative(char[] input, int trueLength)
    {
        int spaceCount = 0;

        for (int i = 0; i < trueLength; i++)
        {
            if (input[i] == ' ')
            {
                spaceCount++;
            }
        }

        int newIndex = trueLength + spaceCount * 2 - 1;

        for (int oldIndex = trueLength - 1; oldIndex >= 0; oldIndex--)
        {
            if (input[oldIndex] == ' ')
            {
                input[newIndex] = '0';
                input[newIndex - 1] = '2';
                input[newIndex - 2] = '%';
                newIndex -= 3;
            }
            else
            {
                input[newIndex] = input[oldIndex];
                newIndex--;
            }
        }

        return input;
    }
    

}