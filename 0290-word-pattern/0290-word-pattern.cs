public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] word = s.Split(" ");

        if(word.Length != pattern.Length ){
            return false;
        }

        Dictionary <char,string> hash = new Dictionary <char,string>();
        Dictionary <string,int> stored = new Dictionary <string,int>();
        for(int i = 0 ; i < pattern.Length ; i ++){
            if(hash.ContainsKey(pattern[i])){
                if(hash[pattern[i]].Equals(word[i])){
                    continue;
                }
                else{
                    return false;
                }
            }
            else{
                hash.Add(pattern[i],word[i]);
                if(stored.ContainsKey(word[i])){
                    return false;
                }
                else{
                    stored.Add(word[i],1);
                }
            }
        }

        return true;
      
    }
}