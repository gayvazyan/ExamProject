using System;
using System.Timers;

namespace Tim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Timer timer = new Timer();
            int h, m, s;
            timer.Interval = 10;
            timer.Start();

            if (timer.Stop)
            {
                Console.WriteLine("Hello World!")

            }
        }
    }
}
