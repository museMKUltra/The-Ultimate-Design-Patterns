using System;

namespace DesignPatterns
{
    public class TextBox : UIControl
    {
        private CheckBox _checkBox;
        public override void Draw()
        {
            Console.WriteLine("Drawing a tex box");
        }
    }
}