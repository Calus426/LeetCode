public class Solution {
    public bool IsValid(string s) {
       

       //example "(([]){})"
         while (s.Contains("()") || s.Contains("[]") || s.Contains("{}")) //if got complete () or {} or []
         {
             s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");//first become ((){}),then(()),then (),last ""
         }
         return s.Length==0;
    }
}