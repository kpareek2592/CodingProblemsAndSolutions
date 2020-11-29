using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Patterns
{
    public class TrianglePatterns
    {
        public static void leftAlignedTraingle(int rows)
        {
            /*
             #
             # #
             # # #
             # # # #
            */
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (j > i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }

                Console.WriteLine();
            }
        }

        public static void rightAlignedTraingle(int rows)
        {
            /*
                   #
                 # #
               # # #
             # # # #
            */
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i + j < rows - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }

                Console.WriteLine();
            }
        }

        public static void rightAlignedUpsideDownTraingle(int rows)
        {
            /*
             # # # #
               # # #
                 # #
                   #
            */
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }

        public static void leftAlignedUpsideDownTraingle(int rows)
        {
            /*
             # # # #
             # # #
             # #
             #
            */
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i + j < rows)
                        Console.Write("#");
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }

        public static void centreTraingle(int rows)
        {
            /*
                        #
                      # # #
                    # # # # #
                  # # # # # # #
            */
            int count = rows - 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(" ");
                    count--;

                    for (int k = 0; k < 2 * i + 1; k++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }
        }


        // Driver code  
        public static void Main1()
        {
            Console.WriteLine("Enter your choice to print pattern.");
            Console.WriteLine("1. Left aligned Triangle \n" +
                              "2. Right aligned Triangle \n" +
                              "3. Left aligned upside down triangle \n" +
                              "4. Right aligned upside down triangle \n" +
                              "5. Centre triangle \n" +
                              "6. Upside down triangle \n" +
                              "7. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    leftAlignedTraingle(rows);
                    break;
                case 2:
                    rightAlignedTraingle(rows);
                    break;
                case 3:
                    leftAlignedUpsideDownTraingle(rows);
                    break;
                case 4:
                    rightAlignedUpsideDownTraingle(rows);
                    break;
                case 5:
                    centreTraingle(rows);
                    break;
                default:
                    Console.WriteLine("Incorrect choice. Exiting");
                    break;
            }
        }
    }
}
