
using BuilderPatternCars.Builders;
using BuilderPatternCars.Directors;

Console.WriteLine("Builder Pattern");

IBuilder builder = new VehicleBuilder(); 
Director director = new Director(builder);
director.ConstructTrack();

var truck = builder.GetVehicle();

Console.WriteLine(truck);

director.ConstractSedan();
var sedan = builder.GetVehicle();
Console.WriteLine(sedan);

director.ConstractSUVCar();
var suv = builder.GetVehicle();
Console.WriteLine(suv);
