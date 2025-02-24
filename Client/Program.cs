using System.Net.Http.Json;

var http = new HttpClient();
var response = await http.GetFromJsonAsync<IEnumerable<WeatherForecast>>("http://localhost:5013/weatherforecast/");
if (response != null)
{
    foreach (var forecast in response)
    {
        Console.WriteLine($"{forecast.Date:d} {forecast.TemperatureC} {forecast.Summary}");
    }
}
else
{
    Console.WriteLine("No response");
}

Console.ReadKey();


return;

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}