namespace Serialization.Decorator.Adapter.Example;

public class Person
{
    public string Name { get; set; } = "Undefined";
    public int Age { get; set; } = 1;
    public Company Company { get; set; } = new Company();

    public Person() { }
    public Person(string name, int age, Company company)
    {
        Name = name;
        Age = age;
        Company = company;
    }
}