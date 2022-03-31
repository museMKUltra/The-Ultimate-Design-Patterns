namespace DesignPatterns.Command.fx
{
    public class Button
    {
        private ICommand _command;
        public string Label { get; set; }

        public Button(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }
    }
}