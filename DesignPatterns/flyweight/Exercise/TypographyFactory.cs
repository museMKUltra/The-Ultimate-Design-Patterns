using System.Collections.Generic;

namespace DesignPatterns.flyweight.Exercise
{
    public class TypographyFactory
    {
        private Dictionary<FontType, Typography> _typographies = new();

        public Typography GetTypography(FontType type)
        {
            if (!_typographies.ContainsKey(type))
            {
                var typography = new Typography(type);
                _typographies.Add(type, typography);
            }

            return _typographies[type];
        }
    }
}