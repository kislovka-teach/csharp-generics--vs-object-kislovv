namespace Serialization.Decorator.Adapter.Example;

public class Process
{
    public static void ProcessModels(List<Person> persons)
    {
        foreach (var person in persons)
        {
            Logger.LogMessage($"Any info about {person.Name}", LogType.Console);
        }
    }
}

public static class Logger
{
    public static void LogMessage(string message, LogType logType)
    {
        if (logType == LogType.None)
        {
            return;
        }

        if ((logType & LogType.Console) == LogType.Console)
        {
            Console.WriteLine(message);
        }

        if ((logType & LogType.File) == LogType.File)
        {
            File.WriteAllText("filelog.log", $"\n\r {message}");
        }
    }
}

[Flags]
public enum LogType
{
    None = 1,
    Console = 2,
    File = 4
}