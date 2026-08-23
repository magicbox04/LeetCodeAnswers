namespace LeetCodeAnswers;

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

class Program {
    static void Main(string[] args) {
        Solution sol = new Solution();
        int[] s = [1,2,3,4];
        
        Console.WriteLine((s));
    }
}