namespace DesignPatternsGof.Behavioral.Mediator;

public interface IMediator<T>
{
    void Send(T message, Collegue<T> from);
}