using AbstractFactoryRealWord2;
using AbstractFactoryRealWord2.AbstractFactory;
using AbstractFactoryRealWord2.ConcreteFactory;

Console.WriteLine("Cliente Abstract factory");

IFurnitureFactory factory = new ModernFactory();
Cliente cliente = new Cliente(factory);
cliente.Run(); 


