using System;

namespace task_5
{
    class Program
    {
        static void Main( string[] args)
        {
            Console.WriteLine("*");

            Console.WriteLine("**");

            Console.WriteLine("***");

            Console.WriteLine("****");

            Console.WriteLine("*****");

            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int n = 1; n <= i; n++)
                {
                    Console.WriteLine("*");
                }

                Console.WriteLine();
            }
        }
    }
}
