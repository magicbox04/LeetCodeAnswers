using System.Data;

namespace LeetCodeAnswers;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}

public class Solution {
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

class Program {
    static void Main(string[] args) {
        Solution sol = new Solution();
        String[] tokens = ["4","13","5","/","+"];
        
        Console.WriteLine(sol.EvalRPN(tokens));
    }
}