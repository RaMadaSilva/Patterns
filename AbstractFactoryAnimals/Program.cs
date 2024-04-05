// See https://aka.ms/new-console-template for more information
using AbstractFactoryAnimals.Client;
using AbstractFactoryAnimals.Factory.Abstract;
using AbstractFactoryAnimals.Factory.Concrete;

Console.WriteLine("Abstract Factory");
ContinenteFactory afrinca = new Africa(); 
var animalword = new AnimalWorld(afrinca);
animalword.RunFoodchain(); 

Console.ReadKey(); 
