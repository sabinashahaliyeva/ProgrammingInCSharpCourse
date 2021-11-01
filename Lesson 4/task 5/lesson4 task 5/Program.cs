using System;

namespace lesson4_task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the day");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the month");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the year");
            int c = int.Parse(Console.ReadLine());

            DateTime date1 = new DateTime(c, b, a);
            Console.WriteLine(date1.ToString ("dd,MM,yyyy"));

            Console.WriteLine("31/12/{0}", c);

        }
    }
}
