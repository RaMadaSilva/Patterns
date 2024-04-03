namespace AbstractFactoryTransporter.AirTransporter;

public class Helicopter : IAirTransporter
{
    public void StartRoute()
    {
        WindCondition();
        TakeCargo();
        Console.WriteLine($"Iniciando viagem via {this.GetType().Name}");
    }

    public void TakeCargo()
    {
        Console.WriteLine("Passageiros Embarcados!");
    }

    public void WindCondition()
    {
        Console.WriteLine("Condição do vento Ok");
    }
}
