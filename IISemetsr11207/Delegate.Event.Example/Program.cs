using Delegate.Event.Example;
using TemperatureAPI;


//В конструктор передана "лямбда" выражение - это синтаксический сахар над анонимным методом помещенным в делегат
var account = new Account(500, (sender,  args) => { Console.WriteLine(args.Message); });
account.Put(200);
account.Withdraw(400);
//account.Notify() - так сделать не позволяет event

//Именнованный метод
void Notify(Account acc, AccountEventArgs args)
{
    Console.WriteLine(args.Message);
}
//Анонимный метод (делегат в который помещен метод) 
var anonDelegate = delegate(Account acc, AccountEventArgs args)
{
    Console.WriteLine(args.Message);
};


var tempNotificator = new TemperatureNotificator("Kazan");
/*var tempData = tempNotificator.GetWeatherData();
Console.WriteLine($"Погода в Казани:\n Температура : {tempData.temp} \n Влажность : {tempData.pressure} \n Видимость : {tempData.humidity}");*/

var observer = new Observer();
//Использование подписки через события
tempNotificator.UpdateEvent += observer.Update;
tempNotificator.Start();

