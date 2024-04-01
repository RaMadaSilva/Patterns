namespace FactoryMethod.Vehicle;

public class Car : IVehicle
{
    public void Route()
    {
        TakeCargo(); 
        Console.WriteLine("Começamos a routa");
    }

    public void TakeCargo()
    {
        Console.WriteLine("Pegamos o passageiro");
    }
}
