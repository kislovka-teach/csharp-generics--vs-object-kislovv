using System.Threading;

namespace TheaterTask
{
    public class Toilet
    {
        Semaphore _semaphore;
        int usedCabines;
        object lockObj = new object();

        public Toilet(int capacity)
        {
            _semaphore = new Semaphore(capacity, capacity);
        }

        public bool TryEnter(Spectator spectator)
        {
            var entered = _semaphore.WaitOne();
            if (entered)
            {
                lock (lockObj)
                {
                    usedCabines++;
                }
            }

            return entered;
        }

        public void Leave(Spectator spectator)
        {
            _semaphore.Release();
            lock (lockObj)
            {
                usedCabines--;
            }
        }
    }
}