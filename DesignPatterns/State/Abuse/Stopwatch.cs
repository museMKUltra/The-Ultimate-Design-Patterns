namespace DesignPatterns.State.Abuse
{
    public class Stopwatch
    {
        public Stopwatch(IState state)
        {
            CurrentState = state;
        }

        public bool IsStop { get; set; }

        public void Click()
        {
            CurrentState.Click(this);
        }

        public IState CurrentState { get; set; }
    }
}