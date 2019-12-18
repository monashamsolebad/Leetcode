public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        int j = 0; 
        int m = s.Length; 
        int n = t.Length;
      
        for (int i = 0; i < n && j < m; i++) 
            if (s[j] == t[i]) 
                j++; 
  
        return (j == m);
    }
}
