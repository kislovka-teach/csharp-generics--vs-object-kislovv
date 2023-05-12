namespace DesignPatternsGof.Behavioral.State;

public interface IProductState
{
    ProductStatus Status { get; set; }
    void UpdateProduct(Product product);
}