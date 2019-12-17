public class Solution {
    public bool IsPalindrome(int x) 
    {
        string word = x.ToString();
        if (word[0].Equals("-")) 
        {
            return false;
        }
        else {
            for (int i = 0; i< word.Length / 2; i++) 
            {
                if (word[i] != word[word.Length -1 - i]) 
                {
                    return false;
                }
             }
            return true;
            }
        }
    }
