
using FactoryMethodRealdWord.Creator.AbstractCreator;
using FactoryMethodRealdWord.Product.ConcretProduct;

namespace FactoryMethodRealdWord.Creator.ConcreteCreator;

public class Resume : Document
{
    public override void CreatePages()
    {
        Pages.Add(new SkyllsPage());
        Pages.Add(new EducationPage());
        Pages.Add(new ExperiencePage());
    }
}
