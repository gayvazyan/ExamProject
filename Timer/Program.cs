using System;
using System.Timers;

namespace Timerss
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }



        private static Timer _timer;

        static void SetTimer()
        {
            _timer = new Timer(10000);
            _timer.Start();

            if (_timer.Elapsed==true)
            {

            }
        }

        private static void Print()
        {
            Console.WriteLine("Jamanaky avartvec");
            Console.WriteLine();
        }

    }
}
