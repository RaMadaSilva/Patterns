using AbstractFactoryRealWord.Factories.AbstractFactory;
using AbstractFactoryRealWord.Factories.ConcreteFactory;
using AbstractFactoryRealWord.Product.AbstractProduct;
using AbstractFactoryRealWord.Product.ConcreteProduct;

Console.WriteLine("Abstract Factory!");

//Factory
Player player = new PlayorFactory(); 

//Product
Futbool futbool = new Chammpions("RealMadrid");
Gammer gammer = new Nerdzola("Baptista");

var result1 = player.CreateSoccar(futbool);
var result2 = player.CreateGammer(gammer);

Console.WriteLine($"{result1.Clube} é um club de futebool" + result1.GetType().Name);
Console.WriteLine($"{result2.Gamer} é um jogar de gamming");

