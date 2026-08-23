namespace LeetCodeAnswers._3_Longest_Substring_Without_Repeating_Characters;
// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        int [] lastIndex = new int[128];
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (lastIndex[s[right]] > left)
            {
                left =  lastIndex[s[right]]; 
            }

            lastIndex[s[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}