using System.Collections.Generic;

namespace DesignPatterns.flyweight
{
    public class PointService
    {
        public List<Point> GetPoints()
        {
            var points = new List<Point>();
            var point = new Point(1, 2, PointType.Cafe, null);
            points.Add(point);

            return points;
        }
    }
}