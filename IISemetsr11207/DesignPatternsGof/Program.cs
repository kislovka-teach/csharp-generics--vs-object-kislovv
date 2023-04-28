// See https://aka.ms/new-console-template for more information

using DesignPatternsGof.Creational.Builder;
using DesignPatternsGof.Structural.Decorator;

var onlyConsoleLogger = ILogger.CreateBuilder()
    .AddConsoleLogger()
    .Build();

var consoleWithFileLogger = ILogger.CreateBuilder()
    .AddConsoleLogger()
    .AddFileLogger("filelog.log")
    .Build();

Console.WriteLine("Hello, World!");