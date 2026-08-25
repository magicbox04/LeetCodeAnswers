namespace LeetCodeAnswers._150_Evaluate_Reverse_Polish_Notation;
// https://leetcode.com/problems/evaluate-reverse-polish-notation/description/
public class Solution
{
    public int EvalRPN(string[] tokens) {
        Stack<string> stack = new Stack<string>();
        
        for (int i =  0; i < tokens.Length; i++)
        {
            if (tokens[i].Equals("+"))
            {
                int a = int.Parse(stack.Pop());
                int b = int.Parse(stack.Pop());
                stack.Push((a + b).ToString());
            }
            else if (tokens[i].Equals("-"))
            {
                int a = int.Parse(stack.Pop());
                int b = int.Parse(stack.Pop());
                stack.Push((a - b).ToString());
            }
            else if (tokens[i].Equals("*"))
            {
                int a = int.Parse(stack.Pop());
                int b = int.Parse(stack.Pop());
                stack.Push((a * b).ToString());
            }
            else if (tokens[i].Equals("/"))
            {
                int a = int.Parse(stack.Pop());
                int b = int.Parse(stack.Pop());
                stack.Push((b / a).ToString());
            }
            else
            {
                stack.Push(tokens[i]);
            }
            
        }

        int.TryParse(stack.Peek(), out int output);
        return output;
    }
}