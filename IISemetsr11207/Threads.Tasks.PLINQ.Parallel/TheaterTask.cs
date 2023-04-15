using System.Text;

namespace Threads.Tasks.PLINQ.Parallel;

internal enum ViewerStatus
{
    Watching,
    InQueue,
    InToilet
}

public class TheaterTask
{
    private const int ToiletCount = 3;
    private const int MovieLength = 20000;
    private const int FPS = 10;
    private const int Rows = 5;
    private const int Columns = 10;
    private static readonly Semaphore _semaphore = new(ToiletCount, ToiletCount);
    private static readonly Random Random = new();
    private static bool IsMovieRunning = true;

    private readonly ViewerStatus[,] _viewers = new ViewerStatus[Rows, Columns];


    public void StartMovie()
    {
        var tasks = InitializeViewers();
        const int frames = FPS * (MovieLength / 1000);
        for (var i = 0; i <= frames; i++)
        {
            Console.Clear();
            var max = Math.Min(Console.WindowWidth, 50);
            var percent = i * max / frames;
            Console.WriteLine(new string('#', percent) + new string('-', max - percent));
            Console.WriteLine($"Время: \t{i * (MovieLength / frames)}");
            Console.WriteLine();
            Console.WriteLine(DrawTheater());
            Thread.Sleep(MovieLength / frames);
        }

        Console.WriteLine("Представление окончено. Всем спасибо за просмотр!");
        IsMovieRunning = false;
    }

    private Task[] InitializeViewers()
    {
        var tasks = new Task[Rows * Columns];
        for (var i = 0; i < Rows * Columns; i++)
        {
            var r = i / Columns;
            var c = i % Columns;
            tasks[i] = Task.Factory.StartNew(() => WatchMovieAsViewer(Random.Next(1000, 10000), r, c));
        }

        return tasks;
    }

    private void WatchMovieAsViewer(int delay, int i, int j)
    {
        Thread.Sleep(delay);
        if (!IsMovieRunning)
            return;

        _viewers[i, j] = ViewerStatus.InQueue;
        _semaphore.WaitOne();
        if (!IsMovieRunning)
            return;

        _viewers[i, j] = ViewerStatus.InToilet;
        Thread.Sleep(Random.Next(1000, 3000));
        if (!IsMovieRunning)
            return;

        _semaphore.Release();
        _viewers[i, j] = ViewerStatus.Watching;
    }

    public void Start()
    {
        IsMovieRunning = true;
        Console.Clear();
        Console.WriteLine("Представление начинается!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(DrawTheater(true));
        Thread.Sleep(500);
        Console.Write("1, ");
        Thread.Sleep(1000);
        Console.Write("2, ");
        Thread.Sleep(1000);
        Console.Write("3!!!");
        Thread.Sleep(1000);
        StartMovie();
    }

    private string DrawTheater(bool isEmpty = false)
    {
        var result = new StringBuilder();
        for (var i = 0; i < Rows; i++)
        {
            result.Append("\u001b[31m|\u001b[0m");
            for (var j = 0; j < Columns; j++)
            {
                result.Append(isEmpty
                    ? "   "
                    : _viewers[i, j] switch
                    {
                        ViewerStatus.Watching => Random.Next(3) switch
                        {
                            0 => "^-^",
                            1 => "o.o",
                            2 => "'u'",
                            _ => "^w^"
                        },
                        ViewerStatus.InQueue => "\u001b[42mT-T\u001b[0m",
                        _ => "\u001b[41m   \u001b[0m"
                    });
                result.Append("\u001b[31m|\u001b[0m");
            }

            result.AppendLine();
        }

        return result.ToString();
    }
}