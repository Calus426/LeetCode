public class Solution {
    public int AddDigits(int num) {
       if(num == 0){
        return 0;
       }
       return num % 9 ==0 ? 9 : num%9;  //casting out nines modulo solution. any num modulo 9 can find the last adding single digit.
    }
}