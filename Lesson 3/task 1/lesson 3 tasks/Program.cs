using System;

namespace lesson_3_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("reqem daxil edin");

            int eded1 = Convert.ToInt32(Console.ReadLine());

            if (eded1 % 2 == 0)
            {
                Console.WriteLine("bu eded cutdur");

            }

            else
            {
                Console.WriteLine("bu eded tekdir");
            }
       
            Console.ReadLine();

        }
    }
}
