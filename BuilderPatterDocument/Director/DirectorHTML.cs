using BuilderPatterDocument.Builder;

namespace BuilderPatterDocument.Director
{
    public class DirectorHTML
    {
        private  IBuildHTML _build; 
        public DirectorHTML(IBuildHTML build)
        {
            _build = build; 
        }

        public void ConstructDocumentWithOutImage(string title, string paragraph, string[] items)
        {
            _build.SetTitle(title);
            _build.SetDescription(paragraph);
            _build.SetList(items); 
        }
        public void ConstructDocumentWithImage(string title, string paragraph, string img)
        {
            _build.SetTitle(title);
            _build.SetDescription(paragraph);
            _build.SetImage(img);
        }

    }
}
