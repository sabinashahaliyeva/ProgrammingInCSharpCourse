using System;

namespace lesson4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;

            DateTime date2 = new DateTime(2004, 04, 26);

            Console.WriteLine(date1 - date2);
        }
    }
}
