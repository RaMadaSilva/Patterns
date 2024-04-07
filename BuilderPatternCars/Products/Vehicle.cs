using BuilderPatternCars.Componetes;

namespace BuilderPatternCars.Products; 

public class Vehicle
{
    public EVehicleTypes VehicleTypes { get; set; }
    public Engine Engine { get; set; }
    public ETransmisionType TransmisionType { get; set; }
    public int Sets { get; set; }
    public string AirBag { get; set; }

    public override string ToString()
    {
        return $"Tipo: {VehicleTypes} Motor: {Engine.Power}  Transmissão: {TransmisionType} Assentos: {Sets} Airbag: {AirBag}"; 
    }
}
