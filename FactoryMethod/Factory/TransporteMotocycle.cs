using FactoryMethod.Vehicle;

namespace FactoryMethod.Factory
{
    public class TransporteMotocycle : Transporte
    {
        protected override IVehicle FactoryMethod()
        {
            return new Motocycle(); 
        }
    }
}
