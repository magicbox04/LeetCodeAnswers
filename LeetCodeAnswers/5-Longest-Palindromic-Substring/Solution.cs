namespace LeetCodeAnswers._5_Longest_Palindromic_Substring;
// https://leetcode.com/problems/longest-palindromic-substring/
public class Solution
{
    public string LongestPalindrome(string s)
    {
        int longestLeft = 0;
        int longestRight = 0;
        for (int midPoint = 0; midPoint < s.Length; midPoint++)
        {
            (int localRight, int localLeft) = expand(s,midPoint, midPoint);
            if (localRight - localLeft > longestRight - longestLeft)
            {
                longestLeft = localLeft;
                longestRight = localRight;
            }
            
            (localRight, localLeft) = expand(s,midPoint, midPoint + 1);
            if (localRight - localLeft > longestRight - longestLeft)
            {
                longestLeft = localLeft;
                longestRight = localRight;
            }
        }
        return s.Substring(longestLeft, longestRight - longestLeft + 1);
    }

    private (int right, int left) expand(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return (right - 1, left + 1);
    }
}