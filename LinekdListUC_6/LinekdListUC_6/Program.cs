using System;
using System.Collections.Generic;


namespace LinkedListUC_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> LinkedList = new List<int>();
            LinkedList.Add(56);
            LinkedList.Add(30);
            LinkedList.Add(70);
            foreach(object obj in LinkedList)
            {
                Console.WriteLine(obj);

            }
            int size = LinkedList.Count;
            LinkedList.RemoveAt(2);
            Console.WriteLine("after removing the last element");
            foreach (object obj in LinkedList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
