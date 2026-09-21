namespace Utilities._7_Reverse_Integer;
// https://leetcode.com/problems/reverse-integer/description/
public class Solution
{
    public int Reverse(int x)
    {
        long result = 0;

        while (x != 0)
        {
            int digit = x % 10;
            x /= 10;
            result = result * 10 + digit;

            if (result < int.MinValue || result > int.MaxValue)
            {
                return 0;
            }
        }
        return (int) result;
    }
}