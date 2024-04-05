namespace BuilderPatternLearn;

public class Director
{
    public void ConstructEconemicHouse(IBuilder builder)
    {
        builder.AddGarden(false);
        builder.AddFlow(1);
        builder.AddNumberOfRoom(2);
    }

    public void ConstructGardenHouse(IBuilder builder)
    {
        builder.AddGarden(true);
        builder.AddFlow(2);
        builder.AddNumberOfRoom(4);
    }
}
