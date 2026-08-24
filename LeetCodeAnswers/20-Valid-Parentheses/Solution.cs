namespace LeetCodeAnswers._20_Valid_Parentheses;
// https://leetcode.com/problems/valid-parentheses/description/

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c =='(')
            {
                stack.Push(')');
            }
            else if (c =='[')
            {
                stack.Push(']');
            }
            else if (c =='{')
            {
                stack.Push('}');
            }
            else
            {
                if (stack.Count == 0)
                    return false;
                if (stack.Peek() != c)
                    return false;
                stack.Pop();
            }
        }
      
        return stack.Count == 0;
    }
}