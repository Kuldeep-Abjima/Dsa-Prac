using Dsa_LinkedList;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        foreach(var item in stack)
        {
            Console.WriteLine(item);
        }
        MyStack myStack = new MyStack(5);

        myStack.push(100);
        myStack.push(400);
        myStack.push(500);
        myStack.push(600);
        
        myStack.Display();


        myStack.pop();
        Console.WriteLine("New stack is");
        myStack.Display();

        MyQueue myQueue = new MyQueue(5);

        myQueue.Enqueue(1000);
        myQueue.Enqueue(2000);
        myQueue.Enqueue(6000);
        myQueue.Enqueue(5000);

        Console.WriteLine("This is Queue");
        myQueue.Display();
    }
}