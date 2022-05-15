using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Android myAndroid = new Android();
            myAndroid.call();
            myAndroid.sendSms();
            myAndroid.turnOff();

            iPhone myiPhone = new iPhone();
            myiPhone.call();
            myiPhone.sendSms();
            myiPhone.turnOff();
        }
    }
}
