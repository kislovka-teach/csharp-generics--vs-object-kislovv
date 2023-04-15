using System;
using System.Threading;
namespace TheaterTask
{
    public class Spectator
    {
        Random random = new Random();
        private int _id;
        Toilet _toilet;
        Thread _thread;
        
        public Spectator(int id, Toilet toilet)
        {
            _toilet = toilet;
            _id = id;
        }

        public void StartWatchingShow()
        {
            _thread = new Thread(() =>
            {
                Thread.Sleep(1000);
                var n = random.Next(1, 3);
                    var enteredToilet = false;
                    if (n == 2)
                    {
                        if (_toilet.TryEnter(this))
                        {
                            enteredToilet = true;
                            Console.WriteLine($"{_id} пошёл в туалет");
                        }
                        if (enteredToilet)
                        {
                            var timeInToilet = random.Next(1, 4);
                            Thread.Sleep(timeInToilet * 1000);
                            _toilet.Leave(this);
                            Console.WriteLine($"{_id} вышел из туалета");
                        }
                    
                }

                
            });
            _thread.Start();
        }

        public void StopWatchingShow()
        {
            _thread.Abort();
        }
    }
}