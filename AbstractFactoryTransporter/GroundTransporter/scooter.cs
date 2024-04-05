namespace AbstractFactoryTransporter.GroundTransporter
{
    public class scooter : IGroundTransporter
    {
        public void StartRoute()
        {
            TakeCargo();
            Console.WriteLine($"iniciando a rota de entrega com {this.GetType().Name}");
        }

        public void TakeCargo()
        {
            Console.WriteLine("Mercadoria pronta para entrega!"); ;
        }
    }
}
