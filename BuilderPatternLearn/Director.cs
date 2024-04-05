namespace BuilderPatternLearn;

public class Director
{
    public void ConstructEconemicHouse(IBuilder builder)
    {
        builder.AddGarden(false);
        builder.AddFlow(1);
        builder.AddNumberOfRoom(2);
    }
}
