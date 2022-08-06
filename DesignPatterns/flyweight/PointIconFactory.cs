using System.Collections.Generic;
using System.Data;

namespace DesignPatterns.flyweight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> _icons = new();
        
        public PointIcon GetPointIcon(PointType type)
        {
            if (!_icons.ContainsKey(type))
            {
                var icon = new PointIcon(type, null);
                _icons.Add(type, icon);
            }

            return _icons[type];
        }
    }
}