using Blog.Common;
using System;

namespace Blog.API
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => Test.MyNumber();

        public string Summary { get; set; }
    }
}
