using AbstractFactoryAnimals.Product.Abstract;

namespace AbstractFactoryAnimals.Factory.Abstract
{
    public abstract class ContinenteFactory
    {
        public abstract IHerbivoro CreateHerbivoro();
        public abstract ICarnivoro CreateCarnivoro();
    }
}
