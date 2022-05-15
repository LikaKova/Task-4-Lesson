using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace honesTAsk
{
    abstract class Phone
	{
		public abstract void call();
		public abstract void sendSms();
		public abstract void turnOff();
		public void turnOn()
		{
			Console.WriteLine("Happy to see you");

		}
	}
}

