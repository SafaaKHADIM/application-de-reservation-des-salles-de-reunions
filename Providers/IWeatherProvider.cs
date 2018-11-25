using System.Collections.Generic;
using test13.Models;

namespace test13.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
