using AbstractFactoryRealWord2.AbstractFactory;
using AbstractFactoryRealWord2.AbstractProduct;
using AbstractFactoryRealWord2.ConcrateProduct;

namespace AbstractFactoryRealWord2.ConcreteFactory;

public class ModernFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair(); 
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa(); 
    }
}
