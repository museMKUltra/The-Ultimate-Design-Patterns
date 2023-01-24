using System.Collections.Generic;

namespace DesignPatterns.prototype.exercise
{
    public class Timeline
    {
        private List<IComponent> _components = new();

        public void Add(IComponent component)
        {
            _components.Add(component);
        }
    }
}