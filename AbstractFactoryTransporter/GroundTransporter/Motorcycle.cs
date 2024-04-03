namespace AbstractFactoryTransporter.GroundTransporter;

public class Motorcycle : IGroundTransporter
{
    public void StartRoute()
    {
        TakeCargo();
        Console.WriteLine($"Iniciando viagem via {this.GetType().Name}");
    }

    public void TakeCargo()
    {
        Console.WriteLine("Mercadoria pronta!");
    }
}
