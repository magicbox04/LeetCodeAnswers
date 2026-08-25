namespace LeetCodeAnswers._150_Evaluate_Reverse_Polish_Notation;
// https://leetcode.com/problems/evaluate-reverse-polish-notation/description/
public class Solution
{
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach (var token in tokens)
        {
            switch (token)
            {
                case "+":
                {
                    int a = stack.Pop(), b = stack.Pop(); stack.Push(b + a); 
                    break;
                }
                case "-":
                {
                    int a = stack.Pop(), b = stack.Pop(); stack.Push(b - a); 
                    break;
                }
                case "*":
                {
                    int a = stack.Pop(), b = stack.Pop(); stack.Push(b * a); 
                    break;
                }
                case "/":
                {
                    int a = stack.Pop(), b = stack.Pop(); stack.Push(b / a); 
                    break;
                }
                default:
                    stack.Push(int.Parse(token));
                    break;
            }
        }

        return stack.Pop();
    }
}