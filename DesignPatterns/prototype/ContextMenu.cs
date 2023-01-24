namespace DesignPatterns.prototype
{
    public class ContextMenu
    {
        public void Duplicate(IComponent component)
        {
            var newComponent = component.Clone();
            // Add target to our document
        }
    }
}