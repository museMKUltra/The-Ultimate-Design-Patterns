namespace DesignPatterns.Memento.Exercise
{
    public class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public DocumentState CreateState()
        {
            return new(Content, FontName, FontSize);
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }

        public void Restore(DocumentState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }

        public void Console()
        {
            System.Console.WriteLine(Content); 
            System.Console.WriteLine(FontName); 
            System.Console.WriteLine(FontSize); 
        }
    }
}