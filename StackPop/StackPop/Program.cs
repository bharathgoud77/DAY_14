using System;
using System.Collections.Generic;

namespace StackUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();

            st.Push(56);
            st.Push(30);
            st.Push(70);
            
            foreach (object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Data in the stack :" + st.Count);
            Console.WriteLine("peek data in the stack :" + st.Peek());
            Console.WriteLine("deleted data in the satck : " + st.Pop());
            Console.ReadKey();
        }
        }
    }
