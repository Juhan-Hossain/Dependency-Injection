using System;

namespace DependencyInjection
{
        public class MockSMSService : ISMSService
        {
        
            private readonly INotifierService _NotifierService;

        public MockSMSService(INotifierService NotifierService)
        {
            _NotifierService = NotifierService;
        }

        public void SendSMS(string mobileNumber, string body)
            {
                SaveSMSToFile(mobileNumber, body);
            _NotifierService.NotifyByEmail(mobileNumber, body);
        }
            public void SaveSMSToFile(string mobileNumber, string body)
            {
                Console.WriteLine("Saving SMS to File using MockSMSService to Mobile: {0}. SMS body: {1}.", mobileNumber, body);
            }

        public void NotifyByEmail(string mobileNumber, string body)
        {
            Console.WriteLine("Notifying by email to Mobile: {0}. SMS Body: {1}.", mobileNumber, body);

        }




    }
    
}