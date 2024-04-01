namespace FactoryMethod.Vehicle
{
    public class Motocycle : IVehicle
    {
        public void Route()
        {
            TakeCargo();
            Console.WriteLine("inicando a rota");
            
        }

        public void TakeCargo()
        {
            Console.WriteLine("Mercadoria em posse");
        }
    }
}
