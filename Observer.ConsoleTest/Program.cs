using Observer.Pattern.Classes;
using System;

namespace Observer.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var station = new WeatherData();
            var display = new CurrentConditionsDisplay(station);

            station.SetMeasurements("24", "70", "1024");
            station.SetMeasurements("25", "60", "1024");
            station.SetMeasurements("26", "50", "1024");
            station.SetMeasurements("27", "40", "1024");

            Console.ReadKey();
        }
    }
}
