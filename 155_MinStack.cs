public class MinStack {
    private Stack<int> stack= new Stack<int>();
    private Stack<int> minstack = new Stack<int>();

    public MinStack() {

    }
    
    public void Push(int val) {
        this.stack.Push(val);
        val = this.minstack.Count>0?Math.Min(val,this.minstack.Peek()):val;
        this.minstack.Push(val);
    }
    
    public void Pop() {
        this.stack.Pop();
        this.minstack.Pop();
    }
    
    public int Top() {
        return this.stack.Peek();
    }
    
    public int GetMin() {
        return this.minstack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */