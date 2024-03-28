using System;
namespace DesignPattern.Bridge
{
    public abstract class AbstractRemoteControl
    {
        protected ILEDTV ledTv;
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}

