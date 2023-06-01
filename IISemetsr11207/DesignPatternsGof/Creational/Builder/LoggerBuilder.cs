using DesignPatternsGof.Structural.Decorator;

namespace DesignPatternsGof.Creational.Builder;

public class LoggerBuilder
{
    private ILogger _logger;

    public LoggerBuilder()
    {
        _logger = new DefaultLogger();
    }

    public LoggerBuilder AddConsoleLogger()
    {
        _logger = new ConsoleLoggerDecorator(_logger);
        return this;
    }

    public LoggerBuilder AddFileLogger(string filePath)
    {
        _logger = new FileLoggerDecorator(filePath, _logger);
        return this;
    }

    public ILogger Build()
    {
        return _logger;
    }
}