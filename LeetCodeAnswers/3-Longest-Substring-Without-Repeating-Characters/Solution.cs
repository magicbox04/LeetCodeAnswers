namespace LeetCodeAnswers._3_Longest_Substring_Without_Repeating_Characters;
// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> lastSeen = new Dictionary<char, int>();
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++) {
            char c = s[right];

            if (lastSeen.ContainsKey(c) && lastSeen[c] >= left) {
                left = lastSeen[c] + 1;
            }

            lastSeen[c] = right;

            int currentLength = right - left + 1;
            if (currentLength > maxLength) {
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
}