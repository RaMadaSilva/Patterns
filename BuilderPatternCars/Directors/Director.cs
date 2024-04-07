using BuilderPatternCars.Builders;
using BuilderPatternCars.Componetes;

namespace BuilderPatternCars.Directors;

public class Director
{
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }


    public void ConstructTrack()
    {
        _builder.SetVehicleType(EVehicleTypes.TRUCK);
        _builder.SetTransmitionType(ETransmisionType.MANUAL);
        _builder.SetSits(4);
        _builder.SetEnginer(new Engine(4000)); 
    }
    public void ConstractSedan()
    {
        _builder.SetVehicleType(EVehicleTypes.SEDAN);
        _builder.SetTransmitionType(ETransmisionType.AUTOMATIC);
        _builder.SetSits(2);
        _builder.SetEnginer(new Engine(2000));
    }
    public void ConstractSUVCar()
    {
        _builder.SetVehicleType(EVehicleTypes.SPORTCAR);
        _builder.SetTransmitionType(ETransmisionType.AUTOMATIC);
        _builder.SetSits(6);
        _builder.SetAirBag("Airbag 3.2"); 
        _builder.SetEnginer(new Engine(2500));
    }
}
