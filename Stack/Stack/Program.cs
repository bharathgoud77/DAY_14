using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();

            st.Push(56);
            st.Push(30);
            st.Push(70);
            
            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }

        }
    }
}