using System;

namespace DesignPatterns.Bridge
{
    public class SonyRemoteControl : RemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("sony turn on");
        }

        public override void TurnOff()
        {
            Console.WriteLine("sony turn off");
        }
    }
}