namespace DesignPatterns.prototype
{
    public class ContextMenu
    {
        public void Duplicate(Component component)
        {
            if (component is Circle source)
            {
                var target = new Circle { Radius = source.Radius };
                // Add target to our document
            }
        }
    }
}