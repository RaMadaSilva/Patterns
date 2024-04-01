using FactoryMethodRealdWord.Product.AbstractProduct;

namespace FactoryMethodRealdWord.Creator.AbstractCreator; 

public abstract class Document
{
    private List<IPage> _pages = new List<IPage>();
    protected Document()
    {
        this.CreatePages();
    }

    public List<IPage> Pages => _pages;

    public abstract void CreatePages(); 
}
