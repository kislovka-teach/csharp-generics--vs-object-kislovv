
using Delegate.Event.Example;
using TemperatureAPI;

var acc = new Account(100);
acc.Put(100);
acc.Withdraw(50);



var tempNotificator = new TemperatureNotificator("Kazan");
var tempData = tempNotificator.GetWeatherData();
Console.WriteLine($"Погода в Казани:\n Температура : {tempData.temp} \n Влажность : {tempData.pressure} \n Видимость : {tempData.humidity}");


