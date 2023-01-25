namespace DesignPatterns.AbstractFactory
{
    public interface IWidgetFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}