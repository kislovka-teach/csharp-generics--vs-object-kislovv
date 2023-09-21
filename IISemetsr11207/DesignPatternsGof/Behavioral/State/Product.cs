namespace DesignPatternsGof.Behavioral.State;

public class Product
{
    public Product()
    {
        State = new GetProductIdeaState();
    }

    public IProductState State { get; set; }
    public TermsOfReference TermsOfReference { get; set; } = null!;
    public Tests Tests { get; set; } = null!;
    public Code Code { get; set; } = null!;
    public bool IsDone { get; set; }

    public void CreateProduct()
    {
        while (!IsDone)
        {
            State.UpdateProduct(this);
        }
    }

    public void UpdateProduct()
    {
        State.UpdateProduct(this);
    }

    public void UseProduct()
    {
        if (State.Status != ProductStatus.Done)
        {
            Console.WriteLine("Нельзя использовать неготовый и не протестированный проукт");
        }
    }

}