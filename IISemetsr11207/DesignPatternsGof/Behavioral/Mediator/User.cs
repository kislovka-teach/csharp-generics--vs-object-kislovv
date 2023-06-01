namespace DesignPatternsGof.Behavioral.Mediator;

public class User : Collegue<string>
{
    public string Name { get; set; }

    public User(IMediator<string> mediator) : base(mediator)
    {
    }

    public override void Notify(string message)
    {
        Console.WriteLine($"{Name} получил сообщение: {message}");
    }

    public void Send(string message)
    {
        _mediator.Send(message, this);
    }
}