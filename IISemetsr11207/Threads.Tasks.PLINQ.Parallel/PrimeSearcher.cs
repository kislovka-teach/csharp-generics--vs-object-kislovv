using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TasksPP = System.Threading.Tasks;

namespace Threads.Tasks.PLINQ.Parallel
{
    public class PrimeSearcher
    {
        public int FindPrimeNumbers(int n)
        { 
            if (n==0 || n==1) return 0;
            if (n==2) return 1;
            if (n==3) return 2;

            int countOfPrimeNumbers = 2;
            var primaryList = new List<int> { 2, 3 };
            int primaryEdge = (int)Math.Sqrt(n);
            for (var i = 4; i <= primaryEdge; i++)
            {
                if(primaryList.All(pr => i % pr != 0))
                {
                    primaryList.Add(i);
                    countOfPrimeNumbers++;
                }
            }
            TasksPP.Parallel.For(primaryEdge + 1, n, (i) =>
            {
                if (primaryList.All(pr => i % pr != 0))
                { 
                    Interlocked.Increment( ref countOfPrimeNumbers);
                }
            });
            return countOfPrimeNumbers;
        }
    }
}
