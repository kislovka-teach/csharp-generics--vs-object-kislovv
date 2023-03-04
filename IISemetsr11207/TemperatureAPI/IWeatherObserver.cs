using System.Data;

namespace TemperatureAPI;

public interface IWeatherObserver
{
    void Update(double temperature, int humidity, int pressure);
}