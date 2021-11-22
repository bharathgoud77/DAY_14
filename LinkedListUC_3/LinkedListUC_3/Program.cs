using System;
using System.Collections.Generic;

namespace LinkedListUC3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> LinkedList = new List<int>();
            LinkedList.Add(56);
            LinkedList.Add(30);
            LinkedList.Add(70);

            foreach (object obj in LinkedList)
            {
                Console.WriteLine(obj);
                Console.ReadKey();
            }

        }
    }
}