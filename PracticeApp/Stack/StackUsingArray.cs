using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PracticeApp.Stack
{
    public class StackUsingArray
    {
        static readonly int MAX = 10;
        int top;
        int[] stack = new int[MAX];

        public StackUsingArray()
        {
            top = -1;
        }

        //Push
        public string Push(int data)
        {
            bool isfull = top >= MAX;
            if (isfull)
                return "Stack is full";
            else
                stack[++top] = data;
            return "Data added";
        }

        //Pop
        public int Pop()
        {
            bool isEmpty = IsEmpty();
            if (isEmpty)
                return 0;
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        //Peep
        public (string response, int value) Peep()
        {
            if (IsEmpty())
            {
                return ("String is Empty", 0);
            }
            else
            {
                int value = stack[top];
                return (null, value);
            }
        }

        private bool IsEmpty()
        {
            return (top < 0);
        }
    }
}
