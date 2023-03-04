namespace ChainResponsibility.Example;

public class VerifyOrderHandler : IHandler<Order>
{
    public IHandler<Order>? Successor { get; set; }
    public void Handle(Order data)
    {
        if (data.CustomerId < 0 || data.OrderTypeId < 0)
            throw new ArgumentException();
        Successor?.Handle(data);
    }
}