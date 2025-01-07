public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        if(s=="")
        {
            return true;
        }

        int checkIndex = 0;

        for (int i = 0;i<t.Length;i++)
        {
            if(s[checkIndex]==t[i])
            {
                checkIndex++;
                if(checkIndex == s.Length)
                {
                    break;
                }
            }
      
        }
        return checkIndex==s.Length?true:false;
    }
}