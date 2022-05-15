using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace honesTAsk
{
     class Android : Phone
     {
        public override void call()
        {
            Console.WriteLine("Call on Android");
        }
        public override void sendSms()
        {
            Console.WriteLine("sms from Android");
        }
        public override void turnOff()
        {
            Console.WriteLine("Good night. Your Android");
        }
    }
}

