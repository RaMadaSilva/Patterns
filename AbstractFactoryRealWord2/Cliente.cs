using AbstractFactoryRealWord2.AbstractFactory;
using AbstractFactoryRealWord2.ConcreteFactory;

namespace AbstractFactoryRealWord2;

public class Cliente
{
    private ModernFactory _modernFactory;
    private VictorianFactory _victorianFactory;

    public Cliente(IFurnitureFactory factory)
    {
        _modernFactory = (ModernFactory)factory.CreateChair();
    }

    public void Run()
    {
        Console.WriteLine("");
    }

}
