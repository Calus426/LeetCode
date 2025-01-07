public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if(numbers.Length==2)
        {
            return new int[]{1,2};
        }
        int lIndex =0;
        int rIndex= numbers.Length-1;
        int sum = 0;

        while(lIndex < rIndex)
        {
            sum = numbers[lIndex]+numbers[rIndex];
            if(sum == target)
            {
               break;
            }
            else if(sum>target)
            {
                rIndex--;
            }
            else
            {
                lIndex++;
            }
        }
        return new int[] {lIndex+1,rIndex+1};

    }
}