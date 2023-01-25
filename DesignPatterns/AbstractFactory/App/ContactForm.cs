using DesignPatterns.AbstractFactory.Ant;
using DesignPatterns.AbstractFactory.Material;

namespace DesignPatterns.AbstractFactory.App
{
    public class ContactForm
    {
        public void Render(Theme theme)
        {
            if (theme == Theme.Ant)
            {
                new AntButton().Render();
                new AntTextBox().Render();
            }
            else if (theme == Theme.Material)
            {
                new MaterialButton().Render();
                new MaterialTextBox().Render();
            }
        }
    }
}