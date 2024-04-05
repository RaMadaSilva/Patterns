using BuilderPatternLearn;

Console.WriteLine("Builder Pattern");

Director director = new Director();
EconomicHouseBuilder economicHouseBuilder = new EconomicHouseBuilder();

director.ConstructEconemicHouse(economicHouseBuilder);
var result = economicHouseBuilder.GetHouse();
Console.WriteLine(result); 

Console.ReadKey(); 
