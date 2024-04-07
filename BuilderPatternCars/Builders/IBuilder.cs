using BuilderPatternCars.Componetes;
using BuilderPatternCars.Products;

namespace BuilderPatternCars.Builders;

public interface IBuilder
{
    Vehicle GetVehicle();
    void SetEnginer(Engine engine); 
    void SetSits(int sits);
    void SetTransmitionType(ETransmisionType transmitionType);
    void SetVehicleType(EVehicleTypes vehicleType);
    void SetAirBag(string airBag);
}
