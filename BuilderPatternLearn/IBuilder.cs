using BuilderPatternLearn.Product;

namespace BuilderPatternLearn;

public interface IBuilder
{
    void Reset(); 
    void AddNumberOfRoom(int number); 
    void AddGarden(bool garden);
    void AddFlow(int numberFlow);
    House GetHouse(); 
}
