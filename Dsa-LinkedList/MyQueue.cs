using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_LinkedList
{
    public class MyQueue
    {
        public int Front { get; private set; }
        public int Rear { get; private set; }

        public int Count { get; private set; }

        public int[] Queue;

        public int ISize { get; set; }
        public MyQueue(int size)
        {
            ISize = size;
            Queue = new int[ISize];
            Front = 0;
            Rear = -1;
            Count = 0;

        }

        public void Enqueue(int value)
        {
            if (Count == ISize)
            {
                Console.WriteLine("Queue is Full");

            }
            else
            {
                if (Rear == ISize - 1)
                {
                    Rear = -1;
                }

                Queue[++Rear] = value;
                Count++;
            }

        }
        public void Dequeue()
        {
            if (Count == 0 || Count == null)
            {
                Console.WriteLine("Queue is Empty");

            }
            else
            {
                Queue[Front] = 0;
                Front = Front + 1;
                Count--;
            }
        }

        public void Display()
        {
            if (Queue.Length == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            else {
                for (int i = 0; i < Queue.Length ; i++)
                {
                    Console.WriteLine(Queue[i]);
                }
            }

        } 
    }
}

