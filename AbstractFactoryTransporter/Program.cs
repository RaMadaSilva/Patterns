
using AbstractFactoryTransporter.Application;
using AbstractFactoryTransporter.TransporterFactory;

Console.WriteLine("Fabrica abstrata de Transportadoras");

Console.WriteLine("Escolha uma transportadora ao seu gosto: ");
Console.WriteLine("1 - Uber");
Console.WriteLine("2 - 99");
Console.WriteLine("3 - Lime");
Console.WriteLine("====================");
_= int.TryParse(Console.ReadLine(), out int option);

IShippingCompanyFactory factory;
Cliente cliente; 

Dictionary<int, Action> options = new()
{
    {1, FactoryUbber}, 
    {2, FactoryNineNine}, 
    {3, FactoryLime}, 
};


if (options.ContainsKey(option))
{
    options[option].Invoke();
}
else
{
    Console.WriteLine("opção incorrecta");
}


void FactoryNineNine()
{
    factory = new NineNine();
    cliente = new Cliente(factory);
    cliente.StartRoute(); 
}

void FactoryUbber()
{
    factory = new Lime();
    cliente = new Cliente(factory);
    cliente.StartRoute();
}

void FactoryLime()
{
    factory = new Lime();
    cliente = new Cliente(factory);
    cliente.StartRoute();
}