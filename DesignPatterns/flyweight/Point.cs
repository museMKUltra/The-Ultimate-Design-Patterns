using System;

namespace DesignPatterns.flyweight
{
    public class Point
    {
        private int _x;
        private int _y;
        private PointIcon _icon;

        public Point(int x, int y, PointIcon icon)
        {
            _x = x;
            _y = y;
            _icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{_icon.Type} at ({_x}, {_y})");
        }
    }
}