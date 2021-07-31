using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface ISMSService
    {
        void SendSMS(string mobileNumber, string body);

    }
}
