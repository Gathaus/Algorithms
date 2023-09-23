namespace Algorithm.LeetCode.Arrays_Hashing;

public class ContainsDuplicate
{
    public class Solution {
        public bool ContainsDuplicate(int[] nums) {
        
            HashSet<int> numsSet = new HashSet<int>();

            foreach(int num in nums){
                if(!numsSet.Contains(num))
                    numsSet.Add(num);
            }

            if(numsSet.Count == nums.Length)
                return false;
            else
                return true;
        }
    }
}