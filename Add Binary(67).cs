public class Solution {
    public string AddBinary(string a, string b) {
       
       int i = 0, rem = 0, res = 0;
int[] sum =  new int[30];
int val1 = Int32.Parse(a);
int val2 = Int32.Parse(b);
  
while (val1 != 0 || val2 != 0) {
   sum[i++] = (val1 % 10 + val2 % 10 + rem) % 2;
   rem =(val1 % 10 + val2 % 10 + rem) / 2;
   val1 = val1 / 10;
   val2 = val2 / 10;
}
  
if (rem != 0)
   sum[i++] = rem;

i = i-1;

while (i >= 0)
   res = res * 10 + sum[i--];
return res.ToString();  
    }
}