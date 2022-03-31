using System;

namespace DesignPatterns.State.Abuse
{
    public class RunningState : IState
    {
        public void Click(Stopwatch stopwatch)
        {
            stopwatch.CurrentState = new StoppedState();
            Console.WriteLine("Stopped");
        }
    }
}