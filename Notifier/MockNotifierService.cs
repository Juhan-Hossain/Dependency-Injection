using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class MockNotifierService:INotifierService
    {
        public void NotifyByEmail(string mobileNumber, string body)
        {
            Console.WriteLine("Mock Notifying by email to Mobile: {0}. SMS Body: {1}.", mobileNumber, body);

        }
    }
}
