public class Solution {
    Dictionary<string, int> mymap = new Dictionary<string, int>()
		{
			{ "M", 1000},
			{ "CM", 900},
			{ "D" , 500},
			{ "CD", 400},
			{ "C" , 100},
			{ "XC" , 90},
			{ "L" , 50},
			{  "XL", 40},
			{ "X", 10},
			{ "IX", 9 },
			{ "V", 5 },
			{ "IV", 4 },
			{ "I", 1},
		};

        public int RomanToInt(String s)
        {
            var res = 0;

            while (!string.IsNullOrEmpty(s))
            {
                foreach (var ch in mymap.Keys)
                {
                    if (s.StartsWith(ch))
                    {
                        res += mymap[ch];
                        s = s.Substring(ch.Length);
                        break;
                    }
                }
            }

            return res;
        }
}