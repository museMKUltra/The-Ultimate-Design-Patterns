namespace DesignPatterns
{
    public class EditorState
    {
        public string Content { get; }

        public EditorState(string content)
        {
            Content = content;
        }

    }
}