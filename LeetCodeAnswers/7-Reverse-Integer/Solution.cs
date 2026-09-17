namespace Utilities._7_Reverse_Integer;
// https://leetcode.com/problems/reverse-integer/description/
public class Solution
{
    public int Reverse(int x)
    {
        string xStr = x.ToString();
        string subStrResult = "";
        string result = "";
        if (xStr.Length != 0 && xStr[0] == '-')
        {
            subStrResult = xStr.Substring(1,  xStr.Length - 1);
            result = "-";
        }
        else
        {
            subStrResult = xStr;
        }
        for (int i = subStrResult.Length - 1; i >= 0; i--)
        {
            result += subStrResult[i];
        }

        try
        {
            int returnValue = int.Parse(result);
            return returnValue;
        }
        catch (OverflowException exception)
        {
            return 0;
        }
    }
}