using FactoryMethodRealdWord.Creator.AbstractCreator;
using FactoryMethodRealdWord.Product.ConcretProduct;

namespace FactoryMethodRealdWord.Creator.ConcreteCreator
{
    public class Reporte : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BiblographyPage());
        }
    }
}
