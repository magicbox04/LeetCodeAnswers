namespace LeetCodeAnswers._242_Valid_Anagram;
// https://leetcode.com/problems/valid-palindrome/description/
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i], 0);
            }

            if (!dict.ContainsKey(t[i]))
            {
                dict.Add(t[i], 0);
            }
            
            dict[s[i]]++;
            dict[t[i]]--;
        }
        
        return dict.Values.All(v => v == 0);
    }
}