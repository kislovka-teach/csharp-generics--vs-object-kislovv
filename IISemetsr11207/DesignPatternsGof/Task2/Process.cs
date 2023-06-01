using Action.Function.Predicate.List.Dict.Example;

namespace DesignPatternsGof.Task2;

public class Process
{
    public static void ProcessData(List<Game> games)
    {
        foreach (var game in games)
        {
            Logger.Log($"any log about {game.Name}", LoggingType.Console | LoggingType.File);
        }
    }
}
public static class Logger
{
    public static void Log(string message, LoggingType loggingType)
    {
        if (loggingType == LoggingType.None)
        {
            return;
        }
        if (loggingType.HasFlag(LoggingType.Console))
        {
            Console.WriteLine(message);
        }

        if (loggingType.HasFlag(LoggingType.File))
        {
            File.WriteAllText("mylog.log", message);
        }
    }
}

[Flags]
public enum LoggingType
{
    None,
    Console,
    File
}