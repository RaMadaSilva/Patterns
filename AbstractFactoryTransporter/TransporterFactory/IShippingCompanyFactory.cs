using AbstractFactoryTransporter.AirTransporter;
using AbstractFactoryTransporter.GroundTransporter;

namespace AbstractFactoryTransporter.TransporterFactory; 

public interface IShippingCompanyFactory
{
    IAirTransporter CreateAirTransporter();
    IGroundTransporter CreateGroundTransporter();
}
