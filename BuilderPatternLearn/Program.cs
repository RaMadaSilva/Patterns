using BuilderPatternLearn;

Console.WriteLine("Builder Pattern");

Director director = new Director();
HouseBuilder economicHouseBuilder = new HouseBuilder();

director.ConstructEconemicHouse(economicHouseBuilder);
var result = economicHouseBuilder.GetHouse();
Console.WriteLine(result); 



Console.ReadKey(); 
