namespace DesignPatternsGof.Structural.Decorator;

public abstract class BaseLoggerDecorator : BaseLogger
{
    protected readonly ILogger Logger;

    protected BaseLoggerDecorator(ILogger logger)
    {
        Logger = logger;
    }
}