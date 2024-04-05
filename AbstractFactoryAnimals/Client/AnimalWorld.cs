using AbstractFactoryAnimals.Factory.Abstract;
using AbstractFactoryAnimals.Product.Abstract;

namespace AbstractFactoryAnimals.Client
{
    public class AnimalWorld
    {
        private readonly IHerbivoro herbivore;
        private readonly ICarnivoro carnivore;

        public AnimalWorld(ContinenteFactory factory)
        {
            herbivore = factory.CreateHerbivoro();
            carnivore = factory.CreateCarnivoro();
        }
        public void RunFoodchain()
        {
            carnivore.Eat(herbivore);
        }
    }
}
