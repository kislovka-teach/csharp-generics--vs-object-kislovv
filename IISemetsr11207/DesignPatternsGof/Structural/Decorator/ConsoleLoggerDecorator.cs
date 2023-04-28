namespace DesignPatternsGof.Structural.Decorator;

public class ConsoleLoggerDecorator : BaseLoggerDecorator
{
    public ConsoleLoggerDecorator(ILogger logger) : base(logger)
    {
    }
    
    public override void LogInformation(string message)
    {
        Console.WriteLine(message);
        Logger.LogInformation(message);
    }
}