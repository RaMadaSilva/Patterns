// See https://aka.ms/new-console-template for more information
using AbstractFactoryAnimals.Client;
using AbstractFactoryAnimals.Factory.Concrete;

Console.WriteLine("Abstract Factory");

var animalword = new AnimalWorld();
animalword.RunFoodchain(); 

Console.ReadKey(); 
