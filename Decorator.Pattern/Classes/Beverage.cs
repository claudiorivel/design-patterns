namespace Decorator.Pattern.Classes
{
    public abstract class Beverage
    {
        public string Description { get; set; }

        public abstract decimal Cost();

        public abstract string GetDescription();
    }
}
