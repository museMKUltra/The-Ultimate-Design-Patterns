namespace DesignPatterns.flyweight
{
    public class PointIcon
    {
        public PointType Type { get; }
        private byte[] _icon;

        public PointIcon(PointType type, byte[] icon)
        {
            Type = type;
            _icon = icon;
        }
    }
}