using DesignPatternsGof.Creational.Builder;

namespace DesignPatternsGof.Structural.Decorator;

public interface ILogger
{
    void LogInformation(string message);

    static LoggerBuilder CreateBuilder()
    {
        return new LoggerBuilder();
    }
}