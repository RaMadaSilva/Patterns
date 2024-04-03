using AbstractFactoryTransporter.AirTransporter;
using AbstractFactoryTransporter.GroundTransporter;

namespace AbstractFactoryTransporter.TransporterFactory;

public class NineNine : IShippingCompanyFactory
{
    public IAirTransporter CreateAirTransporter()
    {
        return new Helicopter(); 
    }

    public IGroundTransporter CreateGroundTransporter()
    {
        return new Car(); 
    }
}
