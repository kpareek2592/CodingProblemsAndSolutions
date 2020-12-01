using System;
using System.Threading;

namespace PracticeApp.Threads
{

    // Demonstrate multiple threads of execution

    // Define a child thread of execution
    class BasicMultithreading
    {

        // Entry point of child thread.
        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Invoking Child Thread #" + i);
                // Yield the rest of the time slice.
                // Simulate thread lifecycle
                Thread.Sleep(500);
                Console.WriteLine("Terminating Child Thread #" + i);
            }
        }

    }

    class ThreadVerse
    {
        static void Main1()
        {
            Console.WriteLine("UI Thread: Start a Child thread.");

            Thread thread = new Thread(new ThreadStart(BasicMultithreading.Run));

            thread.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Running on UI Thread.");
                Thread.Sleep(500);
            }
            Console.WriteLine("UI Thread: Call Join(), to wait until Child Thread terminates.");
            thread.Join();
            Console.WriteLine("UI thread: Run.Join has returned.  Press Enter to end program.");
            Console.ReadLine();
        }

    }
}
}
