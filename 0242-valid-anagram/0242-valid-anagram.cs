public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }

        Hashtable count = new Hashtable();

        foreach(char c in s){
            if(count[c]==null)
            {
                count.Add(c,1);
            }
            else
            {
                count[c] = (int)count[c]+1;
            } 
        }

         foreach(char c in t){
            if(count[c]==null)
            {
                count.Add(c,1);
            }
            else
            {
                count[c]= (int)count[c]-1;
            }
        }

        foreach(int value in count.Values)
        {
            if(value != 0)
            {
                return false;
            }
        }

        return true;
    }
}