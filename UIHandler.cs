using System;

namespace DependencyInjection
{
    
        public class UIHandler
        {
            private ISMSService _SMSService;
            public UIHandler(ISMSService SMSService)
            {
                _SMSService = SMSService;
            }
            public void SendConfirmationMsg(string mobileNumber)
            {
                Console.WriteLine(mobileNumber);
                Console.WriteLine("SMS has been sent to{0} ",mobileNumber);
                _SMSService.SendSMS("123","asd");
            }
        }
}