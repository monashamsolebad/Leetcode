public class Solution {
    public bool IsPowerOfTwo(int x) {
        while (((x % 2) == 0) && x > 1)
    {
        x /= 2;
    }
    return (x == 1);
    }
}
