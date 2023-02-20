namespace ChainResponsibility.Example;

public class CreateOrderHandler : IHandler<Order>
{
    public IHandler<Order>? Successor { get; set; }
    public void Handle(Order data)
    {
        data.Id = Guid.NewGuid();
        Successor?.Handle(data);
    }
}