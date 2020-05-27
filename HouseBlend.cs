namespace DecoratorPattern
{
    public class HouseBlend : IBeverage
    {
        public double cost()
        {
            return 1.99;
        }

        public string getDescription()
        {
            return "House Blend Coffee";
        }
    }
}