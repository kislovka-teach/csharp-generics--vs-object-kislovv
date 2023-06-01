using Serialization.Decorator.Adapter.Example;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Xml.Serialization;
using Serialization.Decorator.Adapter.Example.Decorator;

var company = new Company
{
    EmployeesCount = 5,
    IsGovermental = false,
    Name = "Рога и копыта"
};

var person = new Person("Кирилл", 25, company);

var jsonSerializationText = JsonSerializer.Serialize(person, 
    new JsonSerializerOptions() 
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true
    });

Console.WriteLine(jsonSerializationText);

File.WriteAllText("person.json", jsonSerializationText);

var xmlSerializer = new XmlSerializer(typeof(Person));

using (var file = new FileStream("person.xml", FileMode.OpenOrCreate))
{
    xmlSerializer.Serialize(file, person);
}

Coffe latte = new Latte();
latte = new CoffeMilk(latte);
latte = new CoffeSugar(latte);
latte = new CoffeMilk(latte);
Console.WriteLine(latte.GetCost());

