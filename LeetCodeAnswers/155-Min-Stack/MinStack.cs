namespace LeetCodeAnswers._155_Min_Stack;

public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;
    
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int value) {
        stack.Push(value);
        if (minStack.Count == 0 || minStack.Peek() > value)
            minStack.Push(value);
        else
        {
            minStack.Push(minStack.Peek());
        }
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top()
    {
        return stack.Peek();
    }
    
    public int GetMin()
    {
        return minStack.Peek();
    }
}