using System;

namespace DesignPatterns.flyweight
{
    public class Point
    {
        private int _x;
        private int _y;
        private PointType _type;
        private byte[] _icon;

        public Point(int x, int y, PointType type, byte[] icon)
        {
            _x = x;
            _y = y;
            _type = type;
            _icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{_type} at ({_x}, {_y})");
        }
    }
}