class CStack{
    private List<int> _stack;

    public CStack(){
        _stack = new List<int>();
        Console.WriteLine("Stack Initialized Successfully...");
    }

    public void Push(int value){
        _stack.Add(value);
    }

    public void Pop(){
        if(_stack.Count == 0){
            Console.WriteLine("Stack is empty");
        } else{
              int value = _stack[_stack.Count - 1];
              _stack.RemoveAt(_stack.Count-1);
              Console.WriteLine($"Value popped: {value}");
        }
       
    }
   
}