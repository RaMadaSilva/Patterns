using BuilderPatternLearn.Product;

namespace BuilderPatternLearn;

public class EconomicHouseBuilder : IBuilder
{
    private House _house = new(); 

    public void Reset()
    {
        _house = new(); 
    }
    public void AddFlow(int numberFlow)
    {
        _house.NumberOfFlow = numberFlow;
    }

    public void AddGarden(bool garden)
    {
        _house.HasGarden = garden;
    }

    public void AddNumberOfRoom(int number)
    {
        _house.NumberOfRoom = number;
    }
     public House GetHouse()
    {
        return _house;
    }

}
