using System;
using System.Collections.Generic;

namespace Dequeue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Queue = new Queue<int>();

            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);

            foreach (object obj in Queue)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Data in the Queue :" + Queue.Count);
            Console.WriteLine("peek data in the Queue :" + Queue.Peek());
            Console.WriteLine("deleted data in the Queue : " + Queue.Dequeue());
            Console.ReadKey();
        }
    }
}