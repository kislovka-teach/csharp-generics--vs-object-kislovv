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
#endregion

#region State
/*
var product = new Product();

product.UseProduct();

product.UpdateProduct();

product.UseProduct();

product.CreateProduct();

product.UseProduct();
*/
#endregion

#region Abstract Factory

var elf = new Hero(new ElfFactory());
elf.Hit();
elf.Move();

#endregion


static string SecondProblem(int[] numbers)
{
    var strings = new string[numbers.Length];
    for (var i = 0; i < numbers.Length; i++)
    {
        strings[i] = numbers[i].ToString();
    }

    for (int i = 0; i < strings.Length; i++)
    {
        for (int j = 0; j < strings.Length - 1; j++)
        {
            if ((strings[j] + strings[j + 1]).CompareTo(strings[j + 1] + strings[j]) < 0)
            {
                (strings[j], strings[j + 1]) = (strings[j + 1], strings[j]);
            }
        }
    }

    return string.Join("", strings);
}

var numbers = new int[] { 63, 2, 4, 0, 95, 199, 101 };
var nums = new int[] { 3, 30, 34, 5, 9 };
Console.WriteLine(SecondProblem(nums));