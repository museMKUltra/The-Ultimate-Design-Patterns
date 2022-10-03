using System;

namespace DesignPatterns.Bridge
{
    public class SonyAdvancedRemoteControl : AdvancedRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("sony turn on");
        }

        public override void TurnOff()
        {
            Console.WriteLine("sony turn off");
        }

        public override void SetChannel(int number)
        {
            Console.WriteLine("sony set channel");
        }
    }
}