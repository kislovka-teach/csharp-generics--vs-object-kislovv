namespace DesignPatternsGof.Structural.Decorator;

public class DefaultLogger : BaseLogger
{
    public override void LogInformation(string message)
    {
        return;
    }
}