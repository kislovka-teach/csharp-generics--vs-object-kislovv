namespace Threads.Tasks.PLINQ.Parallel;

public static class ThreadPoolExample
{
    public static void Solve(int[] array, int k)
    {
        var n = array.Length;
        ThreadPool.GetMinThreads(out var threadCount, out _);
        var partCount = (int)Math.Ceiling((double)n / threadCount);
        
        for (var i = 0; i <= threadCount; i++)
        {
            var i1 = i;
            ThreadPool.QueueUserWorkItem(_ => MultiplyRange(array, k, i1 * partCount, partCount));
        }
    }
    
    
    public static void SolveDumb(int[] array, int k)
    {
        MultiplyRange(array, k, 0, array.Length);
    }

    public static void MultiplyRange(int[] array, int k, int startIndex, int length)
    {
        if (startIndex < 0 || startIndex >= array.Length) return;
        for (var i = startIndex; i < Math.Min(array.Length, startIndex + length); i++)
        {
            array[i] *= k;
        }
    }
}