using System;
using System.Collections.Generic;


namespace Queue
{
   
        class Program
        {
            static void Main(string[] args)
            {
            Queue<int> st = new Queue<int>();

            st.Enqueue(56);
                st.Enqueue(30);
                st.Enqueue(70);
                foreach (object  obj in st)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }
