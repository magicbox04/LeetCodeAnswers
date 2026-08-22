namespace LeetCodeAnswers._125_Valid_Palindrome;
// https://leetcode.com/problems/valid-palindrome/description/
public class Solution {
    public bool IsPalindrome(string s) {
        
        string target = new string(s.Where(char.IsLetterOrDigit).ToArray());
        target = target.ToLower();
        int left = 0;
        int right =  target.Length - 1;
        
        while (left < right)
        {
            if (target[left] != target[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}