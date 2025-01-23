public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if(strs.Length ==1)
        {
            return new List<IList<string>>{new List<string>{strs[0]}};
        }

        Dictionary<string,List<string>> anagram= new ();
        
        foreach(string word in strs)
        {
            int[] count = new int[26];

            foreach(char cha in word)
            {
                count[cha - 'a']++;
            }

            StringBuilder sb = new();
            for(int i =0;i<26;i++)
            {
                sb.Append("#");
                sb.Append(count[i]);
            }
            string key = sb.ToString();

            if(!anagram.ContainsKey(key))
            {
                anagram[key] = new List<string>();
            }
            anagram[key].Add(word);
        }
        return new List<IList<string>>(anagram.Values);
    }
}