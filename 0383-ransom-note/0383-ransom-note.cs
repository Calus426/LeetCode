public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(ransomNote.Length>magazine.Length)
        {
            return false;
        }

   

    char[] magazineArray = magazine.ToCharArray(); // change to character array, so that can replace the character.
    int mIndex = 0; //search from 0 (magazineArray index)
    int rIndex= 0; // search from 0 (ransomNote index)
    int tempIndex= 0; // searching start position.
        
        while( rIndex < ransomNote.Length && mIndex < magazine.Length)
        {
            if(ransomNote[rIndex]== magazineArray[mIndex])
            {
                magazineArray[mIndex]=magazineArray[tempIndex]; //move this to the most infront (0)
                rIndex ++; //check the second character
                mIndex= tempIndex; //mIndex = 0
                tempIndex++; //tempIndex =1
                
            }
            mIndex++; //mIndex =1;
        }
        return rIndex==ransomNote.Length;


    }
}