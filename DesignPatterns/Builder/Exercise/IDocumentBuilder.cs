namespace DesignPatterns.Builder.Exercise
{
    public interface IDocumentBuilder
    {
        void AddImage(Image image);
        void AddText(Text text);
        string GetResult();
    }
}