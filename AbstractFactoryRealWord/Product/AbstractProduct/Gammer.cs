namespace AbstractFactoryRealWord.Product.AbstractProduct; 

public abstract class Gammer
{
    protected Gammer(string gammer)
    {
        Gamer = gammer;
    }

    public string Gamer { get; set; }

}
