using System;

namespace DesignPatterns.Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void SetChannel(int number)
        {
            Device.SetChannel(number);
        }
    }
}