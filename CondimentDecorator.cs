namespace DecoratorPattern
{
    public abstract class CondimentDecorator : IBeverage
    {
        protected IBeverage _beverage;
        public CondimentDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }
        public abstract double cost();

        public abstract string getDescription();
    }
}