namespace DesignPatterns.Builder.Exercise
{
    public interface IDocumentBuilder
    {
        void Add(IElement element);

        string GetContent();
    }
}