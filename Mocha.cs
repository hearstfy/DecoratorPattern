namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(IBeverage beverage) : base(beverage)
        {
        }
        public override double cost()
        {
            return .99 + _beverage.cost();
        }

        public override string getDescription()
        {
            return _beverage.getDescription() + ", Mocha";
        }
    }
}