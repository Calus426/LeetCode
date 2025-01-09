public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Array.Sort(nums);

        for(int i=0;i<nums.Length;i++)
        {
            if(i+1 != nums.Length)
            {
                if(nums[i]==nums[i+1])
                {
                    return true;
                }
            }
            else
            {
                break;
            }
        }
        return false;

    }
}