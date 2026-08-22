namespace LeetCodeAnswers._424_Longest_Repeating_Character_Replacement;
// https://leetcode.com/problems/longest-repeating-character-replacement/
public class Solution {
    public int CharacterReplacement(string s, int k)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int left = 0;
        int maxLength = 0;
        int maxCount = 0;
        for (int right = 0; right < s.Length; right++)
        {
            if (!dict.ContainsKey(s[right]))
            {
                dict.Add(s[right], 0);
            }
            dict[s[right]]++;
            maxCount = Math.Max(maxCount, dict[s[right]]);
            while ((right - left) - maxCount >= k)
            {
                dict[s[left]]--;
                left++;
            }

            if (right - left + 1 > maxLength)
            {
                maxLength = right - left + 1;
            }
        }

        return maxLength;
    }
}