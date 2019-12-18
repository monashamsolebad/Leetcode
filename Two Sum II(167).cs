public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        for(int i = 0, j = numbers.Length-1; i< j;)
{
if(numbers[i]+numbers[j] == target)
return new int[] {++i,++j};
else if(numbers[i]+numbers[j] < target)
i++;
else
j--;
}

return new int[] {0,0};
        
    }
}
