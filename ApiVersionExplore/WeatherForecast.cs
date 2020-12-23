using System;

namespace demo
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string Version { get; set; }
    }

    public class WeatherForecastEx : WeatherForecast
    {
        public string Description { get; set; }
    }
}
