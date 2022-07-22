using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite.Exercise
{
    public class Team : IComponent
    {
        private List<IComponent> _components = new();

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Operation()
        {
            foreach (var component in _components)
            {
                component.Operation();
            }
        }
    }
}