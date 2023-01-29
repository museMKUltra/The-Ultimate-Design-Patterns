namespace DesignPatterns.Builder.Exercise
{
    public class Text : IElement
    {
        public string Content { get; }

        public Text(string content)
        {
            Content = content;
        }
    }
}