using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_LinkedList
{
    public class MyStack
    {
        public int Count { get; private set; }
        public int[] Stack;
        public MyStack(int size)
        { 
        
          Stack = new int[size];
          Count = 0;
        
        
        }

        public void push(int value)
        {
            if(Count == Stack.Length)
            {
                Console.WriteLine("stack is full");
            }
            else
            {
                Stack[Count++] = value;
            }
        }
        public int pop()
        {
            int result = -1;
            if (Count == null || Count == 0)
            {
                Console.WriteLine("stack is empty");

            }
            else
            {
                result = Stack[Count--];
            }


            return result;
        }
        public void Display()
        {
            if(Count == null || Count == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                for(int i = Count - 1; i>= 0; --i)
                {
                    Console.WriteLine(Stack[i]);    
                }
            }
        }
    }
}
