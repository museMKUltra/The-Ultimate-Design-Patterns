using System;

namespace DesignPatterns.Bridge
{
    public abstract class AdvancedRemoteControl : RemoteControl
    {
        public abstract void SetChannel(int number);
    }
}