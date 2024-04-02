using AbstractFactoryRealWord2.AbstractProduct;

namespace AbstractFactoryRealWord2.ConcrateProduct
{
    public class ModernChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine(this.GetType().Name) ;
        }

        public int SitOn()
        {
            return 2;
        }
    }
}
