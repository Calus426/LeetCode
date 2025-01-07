public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if(numbers.Length == 2)
        {
            return new int[] {1,2};
        }
        int first=0;
        int sec=0;
        for(int i = 0 ; i<numbers.Length ; i++)
        {
            for(int j = i+1 ; j<numbers.Length;j++)
            {
                if(numbers[i]+numbers[j]==target)
                {
                    first = i+1;
                    sec=j+1;
                    return new int[] {first,sec};
                }
            }
        }
        
        return new int[] {first,sec};
    }
}