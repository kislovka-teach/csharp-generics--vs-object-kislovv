namespace DesignPatternsGof.Behavioral.State;

public class GetProductIdeaState : IProductState
{
    public ProductStatus Status { get; set; } = ProductStatus.Idea;
    public void UpdateProduct(Product product)
    {
        product.TermsOfReference = new TermsOfReference();
        Console.WriteLine("Требования есть, нужен рабочий код!");
        product.State = new CreateCodeState
        {
            Status = ProductStatus.Code
        };
    }
}