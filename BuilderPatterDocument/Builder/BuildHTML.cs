using System.Text;

namespace BuilderPatterDocument.Builder;

public class BuildHTML : IBuildHTML
{
    StringBuilder sb = new StringBuilder();
    public string GetDocument()
    {
       return sb.ToString();
    }

    public void SetDescription(string description)
    {
        sb.Append($"<p>{description}</p>\n");
    }

    public void SetImage(string url)
    {
        sb.Append($"<img src = {url}/>\n"); 
    }

    public void SetList(string[] itens)
    {
        sb.Append("<ul>\n");
        foreach (var item in itens)
        {
            sb.Append($"\t<li>{item}</li>\n"); 
        }
        sb.Append("</ul>\n"); 
    }

    public void SetTitle(string title)
    {
        sb.Append($"<h1>{title}</h1>\n"); 
    }
}
