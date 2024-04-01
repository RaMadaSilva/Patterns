
using FactoryMethodRealdWord.Creator.AbstractCreator;
using FactoryMethodRealdWord.Creator.ConcreteCreator;

Document[] documents = [new Resume(), new Reporte()];

foreach (Document doc in documents)
{
    Console.WriteLine($"{doc.GetType().Name} ---");

    foreach (var page in doc.Pages)
    {
        Console.WriteLine($" {page.GetType().Name} ");
    }
}

Console.ReadKey();
