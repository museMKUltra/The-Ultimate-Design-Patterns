namespace DesignPatterns.Builder.Exercise
{
    public class Image : IElement
    {
        public string Source { get; }

        public Image(string source)
        {
            Source = source;
        }
    }
}