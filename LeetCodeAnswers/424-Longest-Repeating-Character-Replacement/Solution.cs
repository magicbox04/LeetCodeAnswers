namespace LeetCodeAnswers._424_Longest_Repeating_Character_Replacement;
// https://leetcode.com/problems/longest-repeating-character-replacement/
public class Solution {
    public int CharacterReplacement(string s, int k)
    {
        int left = 0;
        int maxFreq = 0;
        int maxLength = 0;
        
        int[] alphabet = new int[26];

        for (int right = 0; right < s.Length; right++)
        {
            alphabet[s[right]-'A']++;
            maxFreq = Math.Max(maxFreq, alphabet[s[right] -'A']);

            while ((right - left + 1) - maxFreq > k)
            {
                alphabet[s[left] - 'A']--;
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}