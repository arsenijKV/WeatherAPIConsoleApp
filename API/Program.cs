using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeatherConsoleApp.Models;
using WeatherConsoleApp;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => {services.AddHttpClient<IWeatherService, WeatherService>();});

using var host = builder.Build();
var svc = host.Services.GetRequiredService<IWeatherService>();

while (true)
{
    await DoTimer();
    await Task.Delay(TimeSpan.FromMinutes(30));
}
async Task DoTimer()

{
    var weather = await svc.GetCurrentWeatherAsync("Vilnius");
    Console.WriteLine($"{weather.Location.Name}, {weather.Location.Country}");
    Console.WriteLine($" Temperature: {weather.Current.Temp_c}°C");
    Console.WriteLine($" Wind: {weather.Current.Wind_kph} km/h");
    Console.WriteLine($" Humidity: {weather.Current.Humidity}%");
    Console.WriteLine($" Condition: {weather.Current.Condition.Text}");
    await Task.CompletedTask;

}
