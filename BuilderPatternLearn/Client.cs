namespace BuilderPatternLearn
{
    public class Client
    {
        Director director = new Director();
        EconomicHouseBuilder economicHouseBuilder = new EconomicHouseBuilder();
        
        public void Main()
        {
            director.ConstructEconemicHouse(economicHouseBuilder);
            var result = economicHouseBuilder.GetHouse();
            Console.WriteLine(result);
        }
    }
}
