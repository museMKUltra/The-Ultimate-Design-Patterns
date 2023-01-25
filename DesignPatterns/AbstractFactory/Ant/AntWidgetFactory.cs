namespace DesignPatterns.AbstractFactory.Ant
{
    public class AntWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new AntButton();
        }

        public ITextBox CreateTextBox()
        {
            return new AntTextBox();
        }
    }
}