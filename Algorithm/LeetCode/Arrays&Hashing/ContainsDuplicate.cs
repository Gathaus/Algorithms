namespace Algorithm.LeetCode.Arrays_Hashing;

public class ContainsDuplicate
{
    public class Solution {
        public bool ContainsDuplicate(int[] nums) {
        
            HashSet<int> numsSet = new HashSet<int>();

            foreach(int num in nums){
                if(numsSet.Contains(num))
                    return true;
                numsSet.Add(num);
            }
            return false;
        }
    }
}