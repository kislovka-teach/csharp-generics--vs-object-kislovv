namespace ChainResponsibility.Example;

public class FixOrderHandler : IHandler<Order>
{
    public IHandler<Order>? Successor { get; set; }
    public void Handle(Order data)
    {
        data.SellingDate = DateOnly.FromDateTime(DateTime.Now);
        Successor?.Handle(data);
    }
}