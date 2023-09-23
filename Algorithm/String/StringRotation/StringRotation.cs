namespace Algorithm.String.StringRotation;

public static class StringRotation
{
    
    public static bool Run(string s1, string s2){
        
        if(s2.Length == 0 && s1.Length == 0)
            return true;

        string concenatedString2 = s2 + s2;

        return concenatedString2.Contains(s1);

    }
}