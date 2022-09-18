namespace DesignPatterns.flyweight.Exercise
{
    public class Typography
    {
        public FontType Type { get; }
        public string FontFamily { get; }
        public int FontSize { get; }
        public bool IsBold { get; }

        public Typography(FontType type)
        {
            Type = type;
            
            switch (Type)
            {
                case FontType.Title:
                    FontFamily = "Arial";
                    FontSize = 14;
                    IsBold = true;
                    break;
                default:
                case FontType.Body:
                    FontFamily = "Times New Roman";
                    FontSize = 12;
                    IsBold = false;
                    break;
            }
        }
    }
}