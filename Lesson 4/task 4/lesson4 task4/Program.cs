using System;

namespace lesson4_task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("gun daxil edin");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("ay daxil edin");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("il daxil edin");

            int c = int.Parse(Console.ReadLine());

            DateTime date1 = new DateTime(c, b, a);
            Console.WriteLine(date1.Date.ToString("dd.MM.yyyy"));

            Console.ReadLine();

        }
    }
}
