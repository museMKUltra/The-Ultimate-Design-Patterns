using System;

namespace DesignPatterns.State.Abuse
{
    public class StoppedState : IState
    {
        public void Click(Stopwatch stopwatch)
        {
            stopwatch.CurrentState = new RunningState();
            Console.WriteLine("Running");
        }
    }
}