using DesignPatterns.AbstractFactory.Ant;
using DesignPatterns.AbstractFactory.Material;

namespace DesignPatterns.AbstractFactory.App
{
    public class ContactForm
    {
        public void Render(IWidgetFactory factory)
        {
            factory.CreateButton().Render();
            factory.CreateTextBox().Render();
        }
    }
}