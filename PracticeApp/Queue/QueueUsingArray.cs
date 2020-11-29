using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PracticeApp.Queue
{
    public class QueueUsingArray
    {
        private int[] queue;
        private int front;
        private int rear;
        private int capacity;
        public QueueUsingArray(int c)
        {
            front = rear = 0;
            capacity = c;
        }

        public void Enqueue(int[] queue, int data)
        {
            // Queue is full
            if(rear == capacity)
            {
                Console.WriteLine("Overflow");
                return;
            }

            // Add the element to the queue
            else
            {
                queue[rear] = data;
                rear++;
            }
            return;
        }

        public void Dequeue(int[] queue, int size)
        {
            // Queue is empty
            if (front == rear)
            {
                Console.WriteLine("Underflow");
                return;
            }

            // Remove the element from the queue and shift remaining elements
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                if (rear < size)
                {
                    queue[rear] = 0;
                }
                rear--;
            }
            return;
        }
    }
}
