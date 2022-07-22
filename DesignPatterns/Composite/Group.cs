using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Group
    {
        private List<Object> _objects = new();

        public void Add(Object shape)
        {
            _objects.Add(shape);
        }

        public void Render()
        {
            foreach (var obj in _objects)
            {
                if (obj is Shape)
                {
                   ((Shape)obj).Render();
                }
                else
                {
                    ((Group)obj).Render();
                }
            }
        }
    }
}