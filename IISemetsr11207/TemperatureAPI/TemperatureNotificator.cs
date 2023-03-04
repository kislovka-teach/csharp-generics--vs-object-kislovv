using Weather.NET;

namespace TemperatureAPI
{
    public class TemperatureNotificator : IWeatherObservable
    {
        private double _temp;
        private int _pressure;
        private int _humidityPercentage;
        private string _city;
        private WeatherClient _client;
        //Если есть event то можно не хранить, вся цепочка хранится в делегате
        private List<IWeatherObserver> _observers = new();
        
        //event сам по себе является свойством, поэтому его можно не оформлять как свойство, оно итак инкапсулированно
        public Action<double, int, int> UpdateEvent = (_, _, _) => { };
        public TemperatureNotificator(string city)
        {
            _city= city;
            _client = new WeatherClient("6e76b58b92fbe1e9c4e9ddf9fc916b53");
            var weatherData = _client.GetCurrentWeather(_city);
            _temp = weatherData.Main.Temperature - 273; 
            _pressure = weatherData.Main.AtmosphericPressure;
            _humidityPercentage = weatherData.Main.HumidityPercentage;
        }

        public void Start() 
        {
            while(true)
            {
                Thread.Sleep(100);
                var weatherData = _client.GetCurrentWeather(_city);
                _temp = weatherData.Main.Temperature - 273; 
                _pressure = weatherData.Main.AtmosphericPressure;
                _humidityPercentage = weatherData.Main.HumidityPercentage;
                NotifyObserveres();
            }
        }

        public (double temp, int humidity, int pressure) GetWeatherData()
        {
            return (Math.Round(_temp, 2), _humidityPercentage, _pressure);
        }
        
        //Если есть event то можно пренебречь, т.к. += это и есть метод Add
        public void AddObserver(IWeatherObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObserveres()
        {
            //Если не через event то необходимо у каждого IObserver вызывать метод Update() 
            UpdateEvent(_temp,_humidityPercentage,_pressure);
        }

        //Если есть event то можно пренебречь, т.к. -= это и есть метод Remove
        public void RemoveObserver(IWeatherObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }
    }
}