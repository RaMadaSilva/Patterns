using AbstractFactoryAnimals.Factory.Abstract;
using AbstractFactoryAnimals.Factory.Concrete;
using AbstractFactoryAnimals.Product.Abstract;

namespace AbstractFactoryAnimals.Client
{
    public class AnimalWorld
    {
        private List<IHerbivoro> herbivores = new(); 
        private List<ICarnivoro> carnivores = new();
 
        public AnimalWorld()
        {
            var animalsAfrica  = new Africa();
            herbivores.Add(animalsAfrica.CreateHerbivoro());
            carnivores.Add(animalsAfrica.CreateCarnivoro());

            var animalsAmerica = new America();
            herbivores.Add(animalsAmerica.CreateHerbivoro());
            carnivores.Add(animalsAmerica.CreateCarnivoro());
        }
        public void RunFoodchain()
        {
            foreach(var carinvore in carnivores)
            {
                foreach(var herbivore in herbivores)
                {
                    carinvore.Eat(herbivore); 
                }
            } 
        }
    }
}
