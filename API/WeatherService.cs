
using System.Text.Json;
using WeatherConsoleApp;
using WeatherConsoleApp.Models;

public class WeatherService : IWeatherService
{
    private readonly HttpClient _httpClient;
    private const string ApiKey = "10689c0ae34b4b34957124836251007";
    private const string BaseUrl = "https://api.weatherapi.com/v1";

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherData> GetCurrentWeatherAsync(string location)
    {
        var url = $"{BaseUrl}/current.json?key={ApiKey}&q={location}&aqi=no";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        var weather = JsonSerializer.Deserialize<WeatherData>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return weather!;
    }
}
