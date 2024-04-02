using AbstractFactoryRealWord.Product.AbstractProduct;
using AbstractFactoryRealWord.Product.ConcreteProduct;

namespace AbstractFactoryRealWord.Factories.AbstractFactory;

public abstract class Player
{
    public abstract Gammer CreateGammer(Gammer g);
    public abstract Futbool CreateSoccar(Futbool f);
}
