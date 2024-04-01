using FactoryMethod.Vehicle;

namespace FactoryMethod.Factory
{
    public abstract class Transporte
    {
        public void StartTransport()
        {
            IVehicle vehicle = FactoryMethod();
            vehicle.Route();
        }
        protected abstract IVehicle FactoryMethod(); 
        
    }
}
