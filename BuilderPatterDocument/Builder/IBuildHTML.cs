namespace BuilderPatterDocument.Builder;

public interface IBuildHTML
{
    void SetTitle(string title);
    void SetDescription(string description);
    void SetList(string[] itens); 
    void SetImage(string url);
    string GetDocument(); 
}
