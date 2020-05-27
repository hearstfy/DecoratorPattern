namespace DecoratorPattern
{
    public class Espresso : IBeverage
    {
        public double cost()
        {
            return 2.99;
        }

        public string getDescription()
        {
            return "Espresso";
        }
    }
}