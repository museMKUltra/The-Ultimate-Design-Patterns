namespace DesignPatterns.flyweight.Exercise
{
    public class Demo
    {
        public static void Show() {
            var sheet = new SpreadSheet(new TypographyFactory());
            sheet.SetContent(0, 0, "Hello");
            sheet.SetContent(1, 0, "World");
            sheet.SetTypography(0, 0, FontType.Title);
            sheet.Render();
        }
    }
}