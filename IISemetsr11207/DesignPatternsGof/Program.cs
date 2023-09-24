using DesignPatternsGof.Behavioral.State;
using DesignPatternsGof.Creational.AbstractFactory;
using DesignPatternsGof.Creational.Builder;
using DesignPatternsGof.Structural.Decorator;

#region Builder
/* 
var onlyConsoleLogger = ILogger.CreateBuilder()
    .AddConsoleLogger()
    .Build();

var consoleWithFileLogger = ILogger.CreateBuilder()
    .AddConsoleLogger()
    .AddFileLogger("filelog.log")
    .Build();

Console.WriteLine("Hello, World!");
*/
//var product = new Product(new GetProductIdeaState());

//product.UseProduct();

//product.UpdateProduct();

//product.UseProduct();

//product.CreateProduct();

//product.UseProduct();

int MaxProfit(int[] prices)
{
    var profit = 0;
    for (int day = 0; day < prices.Length - 1; day++)
    {
        // always buy stock because we can sell it the same day for 0 loss
        profit -= prices[day];
        if (prices[day] > prices[day + 1]) profit += prices[day]; // sell stock same day
        else profit += prices[day + 1]; // else sell stock "tomorrow" for a profit
    }
    return profit;
}

int[] PlusOne(int[] digits)
{
    var hasShift = false;
    var index = digits.Length - 2;

    if (digits[^1] == 9)
    {
        digits[^1] = 0;
        hasShift = true;
    }
    do
    {
        if (hasShift && digits[index] == 9)
        {
            digits[index] = 0;
            hasShift = true;
            index--;
        }
        else
        {
            digits[index]++;
            hasShift = false;
            break;
        }

    }
    while (index > 0);

    if (!hasShift) return digits;

    var copy = new int[digits.Length + 1];
    Array.Copy(digits, 0, copy, 1, digits.Length);
    copy[0] = 1;
    return copy;

}

int MaxProfitLocal(int[] prices, int low, int high)
{
    var innerProfit = 0;
    var n = high - low;
    switch (n)
    {
        case < 1:
            return innerProfit;
        case > 1:
        {
            var mid = low + n / 2;
            innerProfit = MaxProfitLocal(prices, low, mid) + MaxProfitLocal(prices, mid, high);
            break;
        }
    }

    var profit = 0;
    var min = prices[low];
    for (var i = low; i <= high; i++)
    {
        if (prices[i] < min)
        {
            min = prices[i];
        }
        else
        {
            profit = prices[i] - min > profit ? prices[i] - min : profit;
        }
    }
    return profit > innerProfit ? profit : innerProfit;
}

var maxProfit = MaxProfit(new []{7, 1, 5, 3, 6, 4});
