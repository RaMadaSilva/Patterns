using AbstractFactoryRealWord2.AbstractFactory;
using AbstractFactoryRealWord2.AbstractProduct;
using AbstractFactoryRealWord2.ConcrateProduct;

namespace AbstractFactoryRealWord2.ConcreteFactory
{
    public class VictorianFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair(); 
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa(); 
        }
    }
}
