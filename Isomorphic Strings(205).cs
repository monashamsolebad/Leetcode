public class Solution {
    public bool IsIsomorphic(string str1, string str2) {
         if (str1.Length != str2.Length)
            {
                return false;
            }

            var str1Dictionary = new Dictionary<char, char>();
            var str2Dictionary = new Dictionary<char, char>();
            var length = str1.Length;

            for (int i = 0; i < length; i++)
            {
                if (str1Dictionary.ContainsKey(str1[i]))
                {
                    if (str1Dictionary[str1[i]] != str2[i])
                    {
                        return false;
                    }
                }
                else
                {
                    str1Dictionary.Add(str1[i], str2[i]);
                }

                if (str2Dictionary.ContainsKey(str2[i]))
                {
                    if (str2Dictionary[str2[i]] != str1[i])
                    {
                        return false;
                    }
                }
                else
                {
                    str2Dictionary.Add(str2[i], str1[i]);
                }
            }

            return true;
    }
}
