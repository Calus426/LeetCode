public class Solution {
    public int AddDigits(int num) {
        int f = 0;
        int s =0;

        if(num <10 && num > 0 ){
            return num;
        }

        while(num>=10){
            f = num / 10;
            s = num % 10;
            num  = f+s;
        }
        
        return num;
    }
}