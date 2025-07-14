using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherConsoleApp.Models;

namespace WeatherConsoleApp
{
    public interface IWeatherService
    {
        Task<WeatherData> GetCurrentWeatherAsync(string location);
    }
}
