using FactoryMethod.Vehicle;

namespace FactoryMethod.Factory
{
    public class TransporteCar : Transporte
    {
        protected override IVehicle FactoryMethod()
        {
            return new Car(); 
        }
    }
}
