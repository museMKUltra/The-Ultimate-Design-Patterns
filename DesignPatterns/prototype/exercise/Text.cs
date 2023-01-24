namespace DesignPatterns.prototype.exercise
{
    public class Text : IComponent
    {
        private readonly string _content;

        public Text(string content)
        {
            _content = content;
        }

        public IComponent Clone()
        {
            return new Text(_content);
        }
    }
}