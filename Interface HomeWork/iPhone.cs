using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_HomeWork
{
    class iPhone :IallPhone
    {
		public void call()
		{
			Console.WriteLine("Call on iPhone");
		}
		public void sendSms()
		{
			Console.WriteLine("sms from iPhone");
		}
		public void turnOff()
		{
			Console.WriteLine("I don't want to sleep, your iPhone");

		}
	}
}
