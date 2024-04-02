using AbstractFactoryAnimals.Factory.Abstract;
using AbstractFactoryAnimals.Product.Abstract;
using AbstractFactoryAnimals.Product.Concrete;

namespace AbstractFactoryAnimals.Factory.Concrete;

public class America : ContinenteFactory
{
    public override ICarnivoro CreateCarnivoro()
    {
        return new Wolf(); 
    }

    public override IHerbivoro CreateHerbivoro()
    {
        return new Bison(); 
    }
}
