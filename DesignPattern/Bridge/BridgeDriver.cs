using System;
namespace DesignPattern.Bridge
{
	public class BridgeDriver
	{
		public static void Call()
		{
            AbstractRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTV());
            sonyRemoteControl.SwitchOn();
            sonyRemoteControl.SetChannel(101);
            sonyRemoteControl.SwitchOff();
            Console.WriteLine();
            AbstractRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(202);
            samsungRemoteControl.SwitchOff();
        }
	}
}

