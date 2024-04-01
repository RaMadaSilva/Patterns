using FactoryMethod.Factory;

Console.WriteLine("Factory Method");
Console.WriteLine("1 - Carro");
Console.WriteLine("2 - Motorizada");
Console.WriteLine("3 - Bicicleta");

int.TryParse(Console.ReadLine(), out int option);

Dictionary<int, Action> options = new Dictionary<int, Action>
{
    {1,  GetCar},
    {2,  GetMotocycle},
    {3,  GetBicycle},
};

if (options.ContainsKey(option))
{
    options[option].Invoke();
}
else
{
    Console.WriteLine("Opção invalida");
}

Transporte transporte;

void GetMotocycle()
{
    transporte = new TransporteMotocycle();
    transporte.StartTransport();
}

void GetCar()
{
    transporte = new TransporteCar();
    transporte.StartTransport();
}
void GetBicycle()
{
    transporte = new TransporteBicycle();
    transporte.StartTransport();
}
