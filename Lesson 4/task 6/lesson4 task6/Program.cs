using System;

namespace lesson4_task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" gun daxil edin");
            int gun = int.Parse(Console.ReadLine());

            Console.WriteLine(" ay daxil edin ");
            int ay = int.Parse(Console.ReadLine());

            Console.WriteLine(" il daxil edin ");
            int il = int.Parse(Console.ReadLine());

            DateTime datetime = new DateTime(il, ay, gun);

            Console.WriteLine(datetime.DayOfWeek );

            Console.WriteLine(datetime.ToString ("dd,MM,yyyy"));

            if (datetime.DayOfWeek == DayOfWeek.Monday) 
            {
                Console.WriteLine("yuxarida qeyd edilen tarixe gore heftenin son gunu : {0}", datetime.AddDays (6).ToString("dd,MM,yyyy"));
            }

            if (datetime.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("yuxarida qeyd edilen tarixe gore heftenin son gunu : {0}", datetime.AddDays (5).ToString("dd,MM,yyyy"));
            }

            if (datetime.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("yuxarida qeyd edilen tarixe gore heftenin son gunu : {0}", datetime.AddDays(4).ToString("dd,MM,yyyy"));
            }

            if (datetime.DayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine("yuxarida qeyd edilen tarixe gore heftenin son gunu : {0}", datetime.AddDays(3).ToString("dd,MM,yyyy"));
            }

            if (datetime.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("yuxarida qeyd edilen tarixe gore heftenin son gunu : {0}", datetime.AddDays(2).ToString("dd,MM,yyyy"));
            }

            if (datetime.DayOfWeek == DayOfWeek.Saturday )
            {
                Console.WriteLine("yuxarida qeyd edilen tarixe gore heftenin son gunu : {0}", datetime.AddDays(1).ToString("dd,MM,yyyy"));
            }

            if (datetime.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("yuxarida qeyd edilen tarixe gore heftenin son gunu : {0}", datetime.AddDays(0).ToString("dd,MM,yyyy"));
            }

            Console.ReadLine();



        }
    }
}
