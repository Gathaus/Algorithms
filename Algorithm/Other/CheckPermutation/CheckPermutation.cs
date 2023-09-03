namespace Algorithm.Other.CheckPermutation;

public class CheckPermutation
{
    //Cracking the Coding Interview 1.2
    
    public static bool RunWithHashSet(string str1, string str2){
        Dictionary<char,int> resultSet = new Dictionary<char,int>();


        if(str1.Length != str2.Length)
            return false;
        
        foreach(char c in str1){
            if(resultSet.ContainsKey(c))
                resultSet[c]++;
            else{
            resultSet[c] = 1;
            }
        }

        foreach(char c in str2){
            if(!resultSet.ContainsKey(c))
                return false;
            
            resultSet[c]--;

            if(resultSet[c]<0)
                return false;
        }
    
    return true;

    }
}