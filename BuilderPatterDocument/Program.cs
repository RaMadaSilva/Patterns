
using BuilderPatterDocument.Builder;
using BuilderPatterDocument.Director;

IBuildHTML build = new BuildHTML();
DirectorHTML director = new DirectorHTML(build);

Console.WriteLine("Bem vindo ao sistema de crição de paginas HTML");
Console.WriteLine("*************************************************");
Console.WriteLine("*\tEscolha uma das opções abaixo\t\t*");
Console.WriteLine("*\t1 - Documento HTML sem Imangem\t\t*");
Console.WriteLine("*\t2 - Documento HTML Com Imagem  \t\t*");
Console.WriteLine("*************************************************");
Console.WriteLine();
Console.Write("Opcão Escolhida: ");

try
{
    _ = int.TryParse(Console.ReadLine(), out int opcao);
    Console.Clear();
    switch (opcao)
    {
        case 1:
            CreateDocumentWithOutImage();
            break;
        case 2:
            CreateDocumentWithImage();
            break;
        default:
            Console.WriteLine("Opcao inexistente");
            break;
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

void CreateDocumentWithOutImage()
{
    Console.Write("Titulo: ");
    var title = Console.ReadLine();
    Console.WriteLine("Descricao: ");
    var description = Console.ReadLine();
    Console.WriteLine("escreva os itens da lista separado por virugula: ");
    var values = Console.ReadLine();

    string[] items = values.Split(",");

    director.ConstructDocumentWithOutImage(title, description, items);
    Console.WriteLine(build.GetDocument());
}

void CreateDocumentWithImage()
{
    Console.Write("Titulo: ");
    var title = Console.ReadLine();
    Console.WriteLine("Descricao: ");
    var description = Console.ReadLine();
    Console.Write("Url da Imagem: ");
    var url = Console.ReadLine();

    director.ConstructDocumentWithImage(title, description, url);
    Console.WriteLine(build.GetDocument());
}