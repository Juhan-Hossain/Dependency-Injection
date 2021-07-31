using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface INotifierService
    {
        void NotifyByEmail(string mobileNumber, string body);
    }
}
