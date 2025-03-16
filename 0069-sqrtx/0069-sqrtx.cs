public class Solution {
    public int MySqrt(int x) {
        long left =0;
        long right = x;
        long mid ;

        while(left <= right)
        {
            mid = left + (right - left) / 2;

            if(mid * mid > x)
            {
                right = mid - 1;
            }

            else if(mid * mid < x){
                left = mid + 1;
            }

            else{
                 return (int)mid;
            }
        }
        return (int)right;
    }
}