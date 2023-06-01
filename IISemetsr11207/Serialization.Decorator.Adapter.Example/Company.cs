namespace Serialization.Decorator.Adapter.Example;

public class Company
{
    public string Name { get; set; } = "Undefined";
    public int EmployeesCount { get; set; } = 0;
    public bool IsGovermental { get; set; } = false;

    // стандартный конструктор без параметров
    public Company() { }

    public Company(string name) => Name = name;
}
