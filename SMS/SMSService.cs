using System;

namespace DependencyInjection
{
   
        public class SMSService : ISMSService
        {
        public SMSService()
        {
        }

        private readonly INotifierService _NotifierService;
        public SMSService(INotifierService NotifierService)
        {
            _NotifierService = NotifierService;
        }



        public void SendSMS(string mobileNumber, string body)
            {
                SendSMSUsingGateway(mobileNumber, body);
            _NotifierService.NotifyByEmail(mobileNumber, body);
        }

        
        
        private void SendSMSUsingGateway(string mobileNumber, string body)
            {
                Console.WriteLine("Sending SMS using gateway to Mobile: {0}. SMS Body: {1}.", mobileNumber, body);
            }

        public void NotifyByEmail(string mobileNumber, string body)
        {
            Console.WriteLine("Notifying by email to Mobile: {0}. SMS Body: {1}.", mobileNumber, body);

        }
    }
   
}