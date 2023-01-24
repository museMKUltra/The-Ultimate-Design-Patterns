namespace DesignPatterns.prototype.exercise
{
    public class ContextMenu
    {
        private Timeline _timeline;

        public ContextMenu(Timeline timeline)
        {
            _timeline = timeline;
        }

        public void Duplicate(IComponent component)
        {
            _timeline.Add(component);
        }
    }
}