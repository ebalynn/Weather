using System;

namespace Weather.Api
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => ToF();

        private int ToF()
        {
            return 32 + (int)(TemperatureC / 0.5556);
        }

        public string Summary { get; set; }
    }
}
