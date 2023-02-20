namespace ChainResponsibility.Example;

public class Order
{
    public Guid Id { get; set; }

    public int CustomerId { get; set; }
    public int OrderTypeId { get; set; }
    
    public DateOnly SellingDate { get; set; }
}