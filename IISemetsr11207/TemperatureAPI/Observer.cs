namespace TemperatureAPI;

public class Observer : IWeatherObserver
{
    public void Update(double temperature, int humidity, int pressure)
    {
        Console.WriteLine($"Погода в Казани:\n Температура : {temperature} \n Влажность : {pressure} \n Видимость : {humidity} \n");
    }
}