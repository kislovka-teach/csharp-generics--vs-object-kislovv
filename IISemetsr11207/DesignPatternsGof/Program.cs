// See https://aka.ms/new-console-template for more information

using DesignPatternsGof.Behavioral.State;
using DesignPatternsGof.Creational.Builder;
using DesignPatternsGof.Structural.Decorator;
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
var product = new Product(new GetProductIdeaState());

product.UseProduct();

product.UpdateProduct();

product.UseProduct();

product.CreateProduct();

product.UseProduct();