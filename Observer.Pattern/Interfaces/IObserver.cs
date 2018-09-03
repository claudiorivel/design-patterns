namespace Observer.Pattern.Interfaces
{
    public interface IObserver
    {
        void Update(string temp, string humidity, string pressure);
    }
}
