namespace DesignPatternsGof.Structural.Decorator;

public abstract class BaseLogger : ILogger
{
    public abstract void LogInformation(string message);
}