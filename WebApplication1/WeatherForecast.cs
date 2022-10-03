using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace WebApplication1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary => CalculateSummary();

    public string CalculateSummary()
        {
            switch (TemperatureC)
            {
                case int i when i < 0:
                    return "Freezing";
                case int i when i > 0 && i <= 15:
                    return "Chilly";
                case int i when i > 15 && i <= 20:
                    return "Cool";
                case int i when i > 20 && i <= 25:
                    return "Warm";
                case int i when i > 25:
                    return "Hot";
                default:
                    return "greska";
            }
        }
    }
}