using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_HomeWork
{
    class Android : IallPhone
    {
		public void call()
		{
			Console.WriteLine("Call on Android");
		}
		public void sendSms()
		{
			Console.WriteLine("sms from Android");
		}
		public void turnOff()
		{
			Console.WriteLine("Good night. Your Android");
		}
	}
}
