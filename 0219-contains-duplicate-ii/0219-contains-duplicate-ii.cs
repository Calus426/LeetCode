public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int,int> duplicate = new Dictionary<int,int>();
        int count = 0;
        foreach(int num in nums ){
            if(duplicate.ContainsKey(num)){
                if(count - duplicate[num] <= k){
                    return true;  
                }
                else{
                    duplicate[num]= count;
                    count++;
                }
            }
            else{
                duplicate.Add(num,count);
                count++;
            }
           
            
        }
        return false;
    }
}