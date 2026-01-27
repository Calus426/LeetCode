public class Solution {
    public void MoveZeroes(int[] nums) {
        int temp;
        int zeroIndex = 0;
        for(int i = 0 ; i < nums.Length ; i ++){
            if(nums[i] != 0){
                temp = nums[zeroIndex];
                nums[zeroIndex] = nums[i];
                nums[i] = temp;
                zeroIndex++;
            }
            
        }
           
    }
} 
