namespace DecoratorPattern
{
    public class DarkRoast : IBeverage
    {
        public double cost()
        {
            return 1.50;
        }

        public string getDescription()
        {
            return "Dark Roast Coffee";
        }
    }
}