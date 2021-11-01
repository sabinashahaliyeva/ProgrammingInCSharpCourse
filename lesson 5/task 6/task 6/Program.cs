using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("siralarin sayini daxil et:");
            int eded = int.Parse(Console.ReadLine());

            int a = 1;
            for (int i = 1; i < eded; i++)
            {
                for (int n = 1; n <= i; n++)
                {
                    Console.WriteLine("{0} ", a++);
                }
                Console.WriteLine();
            }
        }
    }
}
