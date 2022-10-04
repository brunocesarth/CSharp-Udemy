using System;

namespace Codigo_055 {
    class Program {
        static void Main(string[] args) {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("---------------------");

            TimeSpan t10 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t10);
            Console.WriteLine("Days: " + t10.Days);
            Console.WriteLine("Hours: " + t10.Hours);
            Console.WriteLine("Minutes: " + t10.Minutes);
            Console.WriteLine("Milliseconds: " + t10.Milliseconds);
            Console.WriteLine("Seconds: " + t10.Seconds);
            Console.WriteLine("Ticks: " + t10.Ticks);

            Console.WriteLine("TotalDays: " + t10.TotalDays);
            Console.WriteLine("TotalHours: " + t10.TotalHours);
            Console.WriteLine("TotalMinutes: " + t10.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t10.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t10.TotalMilliseconds);
        }
    }
}
