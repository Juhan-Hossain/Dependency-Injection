using System;
using System.Collections.Generic;
using System.Text;
using Ninject;
using static DependencyInjection.Program;

namespace DependencyInjection
{
    public class MockInjectionModule : NinjectBindings
    {
        // Just a variable to manipulate binding

        private readonly bool UseMockService;
        public MockInjectionModule(bool UseMockService)
        {
            this.UseMockService = UseMockService;
        }

        //overriding load() 
        public override void Load()
        {
            if (UseMockService)
            {
                Bind<ISMSService>().To<MockSMSService>();
                Bind<INotifierService>().To<MockNotifierService>();

            }
            else
            {
                Bind<ISMSService>().To<SMSService>();
                Bind<INotifierService>().To<NotifierService>();
            }
        }
    }
}
