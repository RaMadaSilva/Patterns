namespace AbstractFactoryTransporter.GroundTransporter;

public class Car : IGroundTransporter
{
    public void StartRoute()
    {
        TakeCargo();
        Console.WriteLine($"Iniciando a viagem {this.GetType().Name} ");
    }

    public void TakeCargo()
    {
        Console.WriteLine("Passageiro centado!");
    }
}
