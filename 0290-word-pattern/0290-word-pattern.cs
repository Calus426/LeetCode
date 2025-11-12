public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] word = s.Split(" ");

        if(word.Length != pattern.Length ){
            return false;
        }

        Dictionary <char,string> hash = new Dictionary <char,string>();
        for(int i = 0 ; i < pattern.Length ; i ++){
            //Check Pattern char
            if(hash.ContainsKey(pattern[i])){
                //Check Pattern char value is = to word
                if(hash[pattern[i]].Equals(word[i])){
                    continue;
                }
                else{
                    return false;
                }
            }
            else{
                //Check if the word is belong to any Pattern char.
                if(hash.ContainsValue(word[i])){
                    return false;
                }
                hash.Add(pattern[i],word[i]);        
            }
        }
        return true;
    }
}