using AbstractFactoryTransporter.AirTransporter;
using AbstractFactoryTransporter.GroundTransporter;

namespace AbstractFactoryTransporter.TransporterFactory;

public class UberTransporter : IShippingCompanyFactory
{
    public IAirTransporter CreateAirTransporter()
    {
        return new AirPlane(); 
    }

    public IGroundTransporter CreateGroundTransporter()
    {
        return new Motorcycle(); 
    }
}
