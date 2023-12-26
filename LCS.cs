public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0)
           return 0;
        Array.Sort(nums);
        int count = 0;
        int result = 0;
        for (int i=0; i<nums.Length-1; i++)
        {
            if(nums[i] == nums[i+1])
            continue;
            if(nums[i]+1 == nums[i+1])
            {
               count ++;
               result = Math.Max(result, count);
            }
            else
            {
                count = 0;
            }
        }
        return result+1;
    }
}