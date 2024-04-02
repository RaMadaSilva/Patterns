namespace AbstractFactoryRealWord.Product.AbstractProduct; 

public abstract class Futbool
{
    protected Futbool(string clube)
    {
        Clube = clube;

    }
    public string Clube { get; set; }
}
