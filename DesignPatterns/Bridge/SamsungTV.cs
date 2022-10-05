using System;

namespace DesignPatterns.Bridge
{
    public class SamsungTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("samsung turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("samsung turn off");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine("samsung set channel");
        }
    }
}