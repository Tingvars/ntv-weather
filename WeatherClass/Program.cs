using System;

namespace WeatherClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Weather weather = new Weather(40, 50, "fahrenheit");

            weather.Convert();
        }
    }
}