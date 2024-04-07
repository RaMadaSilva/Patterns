using BuilderPatternCars.Componetes;
using BuilderPatternCars.Products;

namespace BuilderPatternCars.Builders;

public class VehicleBuilder : IBuilder
{
    private Vehicle _vehicle;

    public VehicleBuilder()
    {
        _vehicle = new();
    }
    public Vehicle GetVehicle()
    {
        return _vehicle;
    }

    public void SetAirBag(string airBag)
    {
        _vehicle.AirBag = airBag;
    }

    public void SetEnginer(Engine engine)
    {
        _vehicle.Engine = engine;
    }

    public void SetSits(int sits)
    {
        _vehicle.Sets = sits;
    }

    public void SetTransmitionType(ETransmisionType transmitionType)
    {
        _vehicle.TransmisionType = transmitionType;
    }

    public void SetVehicleType(EVehicleTypes vehicleType)
    {
       _vehicle.VehicleTypes = vehicleType;
    }
}
