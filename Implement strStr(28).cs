public class Solution {
    public int StrStr(string haystack, string needle) {
        
         if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                var start = i;
                var j = 0;
                while (i < haystack.Length && j < needle.Length && haystack[i] ==                            needle[j])
                {
                    i++;
                    j++;
                }

                if (j == needle.Length)
                {
                    return i - needle.Length;
                }

                i = start;
            }

            return -1;
    }
}