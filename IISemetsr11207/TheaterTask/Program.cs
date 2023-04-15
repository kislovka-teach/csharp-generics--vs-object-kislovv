using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TheaterTask
{
    public class Program
    {
        static Semaphore toilet = new Semaphore(5, 5);
        static int usedToilets = 0;
        static object lockObj = new object();
        static Random random = new Random();
        static Timer _timer = null;
        static int ms = 0;
        public static void Main(string[] str)
        {
            var threads = new Thread[300];
            Console.WriteLine("Представление началось");
            _timer = new Timer(TimerCallback, null, 0, 1000);
            for (var i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() => WatchShow(i));
                threads[i].Start();
            }

            for (var i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
            
            Console.WriteLine("Представление окончено");
            /*while (true)
            {
                if (ms >= 20000)
                {
                    Console.WriteLine("Представление окончено");
                    return;
                }
            }
            */
        }

        static void WatchShow(int index)
        {
            while (true)
            {
                Thread.Sleep((int)(random.NextDouble() * 10000));
                var time = random.Next(1, 4);
                if (ms + time * 1000 >= 20000) break;
                if (random.NextDouble() < 0.4 && usedToilets < 5)
                {
                    var enteredToilet = false;
                    lock (lockObj)
                    {
                        if (toilet.WaitOne(0))
                        {
                            usedToilets++;
                            Console.WriteLine($"{index} пошёл в туалет .. Время: {ms} мс");
                            enteredToilet = true;
                        }
                    }

                    if (enteredToilet)
                    {
                        Thread.Sleep(time * 1000);
                        toilet.Release();
                        Console.WriteLine($"{index} вышел из туалета .. Время: {ms} мс"); 
                        usedToilets--;
                    }
                }
            }
        }
        
        private static void TimerCallback(Object o)
        {
            ms += 1000;
        }
    }
}   