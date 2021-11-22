using System;
using System.Collections.Generic;

namespace LinkedList
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
            }
            Console.WriteLine("after inserting");
            int size = LinkedList.Count;
            for (int i = 0; i < size; i++)
            {
                if (LinkedList[i] == 30)
                {
                    LinkedList.Insert(i + 1, 40);
                    break;
                }
            }
            foreach (object obj in LinkedList)
            {
                Console.WriteLine(obj);
            }

        }
    }
}