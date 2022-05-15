using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace honesTAsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
			
				Android myAndroid = new Android();
				myAndroid.call();
				myAndroid.sendSms();
				myAndroid.turnOff();
				myAndroid.turnOn();

				IPhone myiPhone = new IPhone();
				myiPhone.call();
				myiPhone.sendSms();
				myiPhone.turnOff();
				myiPhone.turnOn();
			}
		}
    }

