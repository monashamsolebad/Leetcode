public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if (s.Length != t.Length) return false;
        var seen = new int[256];

        for (int i = 0; i < s.Length; i++)         
        {             
            seen[s[i]]++;             
            seen[t[i]]--;         
        }         
        return seen.All(x => x == 0); 
    }
}
