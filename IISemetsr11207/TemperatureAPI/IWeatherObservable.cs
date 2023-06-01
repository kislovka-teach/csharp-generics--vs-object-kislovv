namespace TemperatureAPI;
/// <summary>
/// Под каждого наблюдателя делается свой Update метод,
/// поэтому указываем конкретный интерфейс
/// </summary>
public interface IWeatherObservable
{
    void AddObserver(IWeatherObserver observer);
    void NotifyObserveres();
    void RemoveObserver(IWeatherObserver observer);
}