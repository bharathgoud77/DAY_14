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
            LinkedList.Add(70);
            LinkedList.Add(30);
            foreach (object obj in LinkedList)
            {
                Console.WriteLine(obj);
                Console.ReadKey();
            }
        }
    }
}