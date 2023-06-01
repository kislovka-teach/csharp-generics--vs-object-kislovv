namespace DesignPatternsGof.Behavioral.State;

public class CreateCodeState : IProductState
{
    public ProductStatus Status { get; set; }
    public void UpdateProduct(Product product)
    {
        if (product.State.Status != ProductStatus.Code && product.State.Status != ProductStatus.Rework)
        {
            throw new InvalidOperationException("Нельзя приступать к разработке пока не будет готовой идеи!");
        }

        product.Code = new Code();
        product.State = new TestProductState
        {
            Status = ProductStatus.Idea
        };
        Console.WriteLine("Код готов! Нужно протестировать!");
        product.State.Status = ProductStatus.Testing;
    }
}