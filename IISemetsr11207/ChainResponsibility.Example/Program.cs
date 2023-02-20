// See https://aka.ms/new-console-template for more information

using ChainResponsibility.Example;

var order = new Order()
{
    CustomerId = 10,
    OrderTypeId = 10
};

var createOrderHandler = new CreateOrderHandler()
{
    Successor = new VerifyOrderHandler()
    {
        Successor = new FixOrderHandler()
        {
            Successor = null
        }
    }
};

createOrderHandler.Handle(order);
Console.WriteLine($"OrderID: {order.Id}\nOrder CustomerID: {order.CustomerId}");
Console.WriteLine($"Order TypeID: {order.OrderTypeId}\nOrder SellingDate: {order.SellingDate}");