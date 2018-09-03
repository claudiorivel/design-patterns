using Observer.Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pattern.Classes
{
    public class WeatherData : ISubject
    {
        readonly List<IObserver> observers;
        string temp;
        string pressure;
        string humidity;

        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            this.observers.ForEach(x => x.Update(temp, humidity, pressure));
        }

        public void SetMeasurements(string temp, string humidity, string pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            this.Notify();
        }

    }
}
