using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace honesTAsk
{
    class IPhone : Phone
    {
		public override void call()
		{
			Console.WriteLine("Call on iPhone");
		}
		public override void sendSms()
		{
			Console.WriteLine("sms from iPhone");
		}
		public override void turnOff()
		{
			Console.WriteLine("I don't want to sleep, your iPhone");

		}
	}
}
