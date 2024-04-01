using FactoryMethod.Vehicle;

namespace FactoryMethod.Factory
{
    public class TransporteBicycle : Transporte
    {
        protected override IVehicle FactoryMethod()
        {
            return new Bicycle();
        }
    }
}
