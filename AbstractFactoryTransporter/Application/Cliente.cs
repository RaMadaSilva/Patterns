using AbstractFactoryTransporter.AirTransporter;
using AbstractFactoryTransporter.GroundTransporter;
using AbstractFactoryTransporter.TransporterFactory;

namespace AbstractFactoryTransporter.Application;

public class Cliente
{
    private readonly IAirTransporter _airTransporter; 
    private readonly IGroundTransporter _groundTransporter;
    public Cliente(IShippingCompanyFactory factory)
    {
        _airTransporter = factory.CreateAirTransporter(); 
        _groundTransporter = factory.CreateGroundTransporter();
    }

    public void StartRoute()
    {
        _airTransporter.StartRoute(); 
        _groundTransporter.StartRoute();
    }
}
