using AbstractFactoryRealWord2.AbstractProduct;

namespace AbstractFactoryRealWord2.AbstractFactory; 

public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
}
