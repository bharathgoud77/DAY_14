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
            foreach (object obj in LinkedList)
            {
                Console.WriteLine(obj);
            }
            LinkedList.Insert(1, 30);
            Console.WriteLine(" inserting 30 between 56 and 70");
            foreach (object obj in LinkedList)
            {
                Console.WriteLine(obj);
                //Console.ReadKey();
            }



        }
    }
}