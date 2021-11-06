using System;

namespace task_1._2._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("10 ile yuz arasinda eded daxil edin");
            int eded = Convert.ToInt32(Console.ReadLine());

            int[] ededler = new int[eded];

            for (int i = 0; i < eded; i++)
            {

                ededler[i] = random.Next(1, 101);
                Console.WriteLine("x[{0}] = {1}", i, ededler[i]);
            }

            Console.WriteLine("---------------");

            Console.WriteLine("artan sira ile ");

            Array.Sort(ededler);

            foreach (var num in ededler) 
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------------");

            Console.WriteLine("maksimum 3cu element {0}.", ededler[2]);

            Console.WriteLine("---------------");

            Console.WriteLine("maksimum 4cu element : ");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(ededler[i]);
            }
        }
    }
}
