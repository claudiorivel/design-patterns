using Observer.Pattern.Interfaces;
using System;

namespace Observer.Pattern.Classes
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        ISubject weatherData;
        string temp;
        string humidity;
        string pressure;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.Register(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current Coditions: {temp}, {humidity}, {pressure}");
        }

        public void Update(string temp, string humidity, string pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            this.Display();
        }
    }
}
