/*using System.Threading.Channels;
using Microsoft.VisualBasic;
using Threads.Tasks.PLINQ.Parallel;

var n = 10000;
var m = 10000;
var zemla = new int[n,m];
var plan = new int[n,m];
var Worker1 = new Thread(WorkHorizontal);
var Worker2 = new Thread(WorkVertical);

for (var i = 0; i < n; i++)
{
    for (var j = 0; j < m; j++)
    {
        plan[i, j] = 1;
    }
}

void WorkHorizontal()
{
    for (var i = 0; i < n; i++)
    {
        if (i % 2 == 0)
        {
            for (var j = 0; j < m; j++)
            {
                zemla[i, j] = plan[i, j];
            }
        }
        else
        {
            for (var j = m - 1; j >= 0; j--)
            {
                zemla[i, j] = plan[i, j];
            }
        }
    }
}

void WorkVertical()
{
    for (int i = m - 1; i >= 0; i--)
    {
        if (m % 2 == i % 2)
        {
            for (var j = 0; j < n; j++)
            {
                zemla[i, j] = plan[i, j];
            }
        }
        else
        {
            for (var j = n - 1; j >= 0; j--)
            {
                zemla[i, j] = plan[i, j];
            }
        }
    }
}

Worker1.IsBackground = true;
Worker2.IsBackground = true;
ThreadPool.GetMaxThreads(out var workerThreads, out var completionPortThreads);
Console.WriteLine($"{workerThreads} {completionPortThreads}");
//Worker1.Start();
//Worker2.Start();
//Worker1.Join();
//Worker2.Join();
//Console.WriteLine(plan.Cast<int>().SequenceEqual(zemla.Cast<int>()));
Console.WriteLine(plan[n/2, m/2] == zemla[n/2, m/2]);
//Thread.Sleep(5000);
//Console.WriteLine(plan[n/2, m/2] == zemla[n/2, m/2]);


var end = 100000000;
var array = Enumerable.Range(1, end).ToArray();
ThreadPoolExample.Solve(array, 7);

//Thread.Sleep(500);
//Console.WriteLine(string.Join(" ", array));
while (array[^1] == end) ;
Console.WriteLine($"{array[0]}, {array[1]}..{array[array.Length / 2]}..{array[^2]}, {array[^1]}");
*/
using System;
using System.Threading;
using Threads.Tasks.PLINQ.Parallel;


public class Program
{
    public static Semaphore semaphore = new Semaphore(5, 5);
    public static Random random = new Random();

    /// <summary>
    /// Зрители заходят в зал и смотрят представление.
    /// </summary>
    public static void Main(string[] args)
    {
        Thread threadTheatre = new Thread(new ThreadStart(TheaterShow));
        threadTheatre.Start();
        var numbers = Enumerable.Range(1, 300).ToList();
        var numbersCopy = new List<int>(numbers);

        for (var i = 0; i < numbers.Count; i++)
        {
            var pickIndex = random.Next(numbersCopy.Count);
            var randNumber = numbersCopy[pickIndex];

            Thread threadToilet = new Thread(new ParameterizedThreadStart(AttendShow!));
            threadToilet.Start(randNumber);

            numbersCopy.RemoveAt(pickIndex);
        }
    }

    /// <summary>
    /// Представление. Да кто-то не успел выйти из туалета и остался там...
    /// </summary>
    static void TheaterShow()
    {
        Console.WriteLine("Представление началось");

        Thread.Sleep(20000);

        Console.WriteLine("Представление закончилось");

        Environment.Exit(0);
    }

    /// <summary>
    /// Перегрузка метода для того чтобы работало ParameterizedThreadStart.
    /// </summary>
    public static void AttendShow(object id) => AttendShow(new Viewer((int)id));

    /// <summary>
    /// Некоторые зрители хотят в туалет. Заходят и выходят.
    /// </summary>
    public static void AttendShow(Viewer viewer)
    {
        viewer.WantToilet();
        int timeInBathroom = random.Next(1, 4);

        viewer.WaitToilet();
        semaphore.WaitOne();
        semaphore.WaitOne();

        viewer.ComeToilet();
        semaphore.Release();
        Thread.Sleep(timeInBathroom * 1000);

        viewer.ExitToilet();
        semaphore.Release();
    }
}
