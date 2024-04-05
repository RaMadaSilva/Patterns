using AbstractFactoryTransporter.AirTransporter;
using AbstractFactoryTransporter.GroundTransporter;

namespace AbstractFactoryTransporter.TransporterFactory;

public class Lime : IShippingCompanyFactory
{
    public IAirTransporter CreateAirTransporter()
    {
        return new Drone(); 
    }

    public IGroundTransporter CreateGroundTransporter()
    {
        return new scooter();
    }
}
