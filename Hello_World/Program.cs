using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name?");
            var username = Console.ReadLine();
            Console.WriteLine($"\nHello {username}!");
            DateTime now = GetNow();
            int dayOfYear = now.DayOfYear;

            Console.Write("Day of year: ");
            Console.WriteLine(dayOfYear);
        }

        private static DateTime GetNow()
        {
            return DateTime.Now;
        }
    }
}
