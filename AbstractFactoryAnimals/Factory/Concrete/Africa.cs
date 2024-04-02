using AbstractFactoryAnimals.Factory.Abstract;
using AbstractFactoryAnimals.Product.Abstract;
using AbstractFactoryAnimals.Product.Concrete;

namespace AbstractFactoryAnimals.Factory.Concrete
{
    public class Africa : ContinenteFactory
    {
        public override ICarnivoro CreateCarnivoro()
        {
            return new Lion(); 
        }

        public override IHerbivoro CreateHerbivoro()
        {
            return new Wildebeest(); 
        }
    }
}
