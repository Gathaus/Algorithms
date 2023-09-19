using System.Text;

namespace Algorithm.Other.StringCompression;

public static class StringCompression
{
    public static string Run(string str)
    {
        if (str == "" || str == null)
            return str;
        var resultStr = new StringBuilder();
        
        int count = 1;
        char tempChar = str[0];
        for(int i =1; i<str.Length; i++){
            if(str[i] == tempChar)
                count++;
            else{
                resultStr.Append(tempChar);
                tempChar = str[i];
                resultStr.Append(count.ToString());
                count = 1;
            }

        }
        resultStr.Append(tempChar);
        resultStr.Append(count.ToString());

        if(resultStr.Length < str.Length)
            return resultStr.ToString();
        else
            return str;

    }
}