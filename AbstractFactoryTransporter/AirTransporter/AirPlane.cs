namespace AbstractFactoryTransporter.AirTransporter;

public class AirPlane : IAirTransporter
{
    public void StartRoute()
    {
        WindCondition();
        TakeCargo();
        Console.WriteLine($"Inicando a viagem via {this.GetType().Name}");
    }

    public void TakeCargo()
    {
        Console.WriteLine("Pegando as Passageiros"); ;
    }

    public void WindCondition()
    {
        Console.WriteLine("Condição do Vento Ok");
    }
}
