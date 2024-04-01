namespace FactoryMethod.Vehicle
{
    public class Bicycle : IVehicle
    {
        public void Route()
        {
            TakeCargo();
            Console.WriteLine("Começando uma rota de Bicleta");
        }

        public void TakeCargo()
        {
            Console.WriteLine("Pegando a carga!");
        }
    }
}
