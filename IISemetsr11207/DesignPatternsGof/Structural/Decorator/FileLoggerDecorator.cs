namespace DesignPatternsGof.Structural.Decorator;

public class FileLoggerDecorator : BaseLoggerDecorator
{
    private readonly string _loggerPath;
    public FileLoggerDecorator(string loggerPath, ILogger logger) : base(logger)
    {
        _loggerPath = loggerPath;
    }
    
    public override void LogInformation(string message)
    {
        File.WriteAllText(_loggerPath, $"\n\r {message}");
        this.Logger.LogInformation(message);
    }
}