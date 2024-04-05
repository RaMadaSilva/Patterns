namespace BuilderPatternLearn.Product;

public class House
{
    public int NumberOfRoom { get; set; }
    public bool HasGarden { get; set; }
    public int NumberOfFlow { get; set; }

    public override string ToString()
    {
        return $"Numero de Quartos: {NumberOfRoom} \n Tem Jardin?: {HasGarden} \n Numero de Pisos: {NumberOfFlow}"; 
    }
}
