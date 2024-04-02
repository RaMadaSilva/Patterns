using AbstractFactoryAnimals.Product.Abstract;

namespace AbstractFactoryAnimals.Product.Concrete
{
    public class Lion : ICarnivoro
    {
        public void Eat(IHerbivoro herbivoro)
        {
            Console.WriteLine($"{this.GetType().Name} come {herbivoro.GetType().Name}");
        }
    }
}
