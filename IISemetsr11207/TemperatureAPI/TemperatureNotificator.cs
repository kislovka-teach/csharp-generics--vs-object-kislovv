using Weather.NET;

namespace TemperatureAPI
{
    public class TemperatureNotificator
    {
        private double _temp;
        private int _pressure;
        private int _humidityPercentage;
        private string _city;
        private WeatherClient _client;
        public TemperatureNotificator(string city)
        {
            _city= city;
            _client = new WeatherClient("6e76b58b92fbe1e9c4e9ddf9fc916b53");
            var weatherData = _client.GetCurrentWeather(_city);
            _temp = weatherData.Main.Temperature - 273; 
            _pressure = weatherData.Main.AtmosphericPressure;
            _humidityPercentage = weatherData.Main.HumidityPercentage;
        }

        private void Update() 
        {
            while(true)
            {
                Task.Delay(10000);
            }
        }

        public (double temp, int humidity, int pressure) GetWeatherData()
        {
            return (Math.Round(_temp, 2), _humidityPercentage, _pressure);
        }
    }
}