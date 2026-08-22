namespace LeetCodeAnswers._49_Group_Anagrams;
// https://leetcode.com/problems/group-anagrams/description/
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> groups = new Dictionary<string, IList<string>>();

        foreach (string str in strs)
        {
            int [] alphabet = new int[26];
            foreach (char c in str)
            {
                alphabet[c - 'a']++;
            }

            string key = string.Join(",", alphabet);
            if (!groups.ContainsKey(key))
            {
                groups.Add(key, new List<string>());
            }
            groups[key].Add(str);
        }
        
        return groups.Values.ToList();
    }
}