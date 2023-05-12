namespace DesignPatternsGof.Behavioral.Mediator;

public abstract class Collegue<T>
{
    protected IMediator<T> _mediator;

    protected Collegue(IMediator<T> mediator)
    {
        _mediator = mediator;
    }

    public abstract void Notify(string message);
}