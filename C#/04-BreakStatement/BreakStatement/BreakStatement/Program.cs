using System;

namespace BreakStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Question: If the break statement of inner loop is hit will the outer loop continue execution or not?
            */

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 3)
                        break;
                    Console.WriteLine($"j " + j);
                }
                Console.WriteLine($"i " + i);
            }
            Console.ReadLine();
        }
    }
}
