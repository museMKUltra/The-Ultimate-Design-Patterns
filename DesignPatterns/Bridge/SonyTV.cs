using System;

namespace DesignPatterns.Bridge
{
    public class SonyTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("sony turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("sony turn off");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine("sony set channel");
        }
    }
}