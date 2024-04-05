namespace AbstractFactoryTransporter.AirTransporter;

public class Drone : IAirTransporter
{
    public void StartRoute()
    {
        WindCondition();
        TakeCargo();
        Console.WriteLine($"Iniciando a rota de entrega via {this.GetType().Name}");
    }

    public void TakeCargo()
    {
        Console.WriteLine("Produto Abordo"); ;
    }

    public void WindCondition()
    {
        Console.WriteLine("Vento para suporte de drone OK"); 
    }
}
