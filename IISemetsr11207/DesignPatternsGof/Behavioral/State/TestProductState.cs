namespace DesignPatternsGof.Behavioral.State;

public class TestProductState : IProductState
{
    public ProductStatus Status { get; set; }
    public void UpdateProduct(Product product)
    {
        var tests = new Tests();
        product.Tests ??= tests;
        product.Tests.IsSuccess = new Random().Next(0, 2) == 1;

        if (product.Tests.IsSuccess || product.Tests.FailCount >= 5)
        {
            Console.WriteLine("Проект готов!");
            product.State.Status = ProductStatus.Done;
            product.IsDone = true;
        }
        else
        {
            product.Tests.FailCount++;
            Console.WriteLine($"Проект требует доработки. Количество неудачных попыток тестирования {product.Tests.FailCount}");
            product.State = new CreateCodeState
            {
                Status = ProductStatus.Rework
            };
        }
    }
}