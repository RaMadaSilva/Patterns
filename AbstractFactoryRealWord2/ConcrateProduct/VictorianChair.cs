using AbstractFactoryRealWord2.AbstractProduct;

namespace AbstractFactoryRealWord2.ConcrateProduct;

public class VictorianChair : IChair
{
    public void HasLegs()
    {
        Console.WriteLine(this.GetType().Name);
    }

    public int SitOn()
    {
        return 3;
    }
}
