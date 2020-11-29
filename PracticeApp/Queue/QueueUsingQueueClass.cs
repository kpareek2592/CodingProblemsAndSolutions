using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Queue
{
    public class QueueUsingQueueClass
    {
        public void QueueImplementation()
        {
            Queue<int> queue = new Queue<int>(5);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.ToArray());
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);
            queue.Clear();
            Console.WriteLine(queue.Count);
        }
    }
}
