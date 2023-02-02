using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class StackImplementation
    {
        const int size = 10;
        int[] arr = new int[size];
        int top;

        void push(int i)
        {
            if (top >= size)
            {
                Console.WriteLine("Stack is overflowed");
            }
            else
            {
                arr[top] = i;
                top++;
                Console.WriteLine($"{i} added into stack");
            }
        }

        void pop()
        {
            if (top == 0)
            {
                Console.WriteLine("Stack is Underflowed");
            }
            else
            {
                
                --top;
                Console.WriteLine($"{arr[top]} is poped from stack");
            }
        }
        void peek()
        {
            if (top == 0)
            {
                Console.WriteLine("First add elements in stack");
            }
            else
            {
                Console.WriteLine($"{arr[top-1]} is at the peek of stack");
            }
           
        }

        void display()
        {
            Console.Write("Elements of stack are as follow :");
            for(int i = 0; i < top; i++)
            {
                Console.Write($"-->{arr[i]}");
            }
        }

        public static void Main(String[] args)
        {
            StackImplementation st = new StackImplementation();
            st.push(10);
            st.pop();
            st.push(20);
            st.push(30);
            st.peek();
            st.display();
        }
    }
}
