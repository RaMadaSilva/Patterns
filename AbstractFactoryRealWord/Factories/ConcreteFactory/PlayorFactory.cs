using AbstractFactoryRealWord.Factories.AbstractFactory;
using AbstractFactoryRealWord.Product.AbstractProduct;
using AbstractFactoryRealWord.Product.ConcreteProduct;

namespace AbstractFactoryRealWord.Factories.ConcreteFactory;

public class PlayorFactory : Player
{
    public override Gammer CreateGammer(Gammer g)
    {
        return new Nerdzola(g.Gamer); 
    }

    public override Futbool CreateSoccar(Futbool f)
    {
        return new Chammpions(f.Clube); 
    }
}
