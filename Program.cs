using System;
using System.Collections.Generic;
using System.Reflection;
using Ninject;
namespace DependencyInjection
{
    public class Program
    {
        private static bool UseMockService;
        static void Main(string[] args)
        {
            Console.WriteLine("please Enter 1 to Use MockService:");
            Console.WriteLine("please Enter 2 to Use SMSService:");
            int x = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            switch (x)
            {
                case 1:
                    UseMockService = true;
                    break;
                case 2:
                    UseMockService = false;
                    break;
                default:
                    {
                        Console.WriteLine("An Error occured! plaese enter beetween 1/2");
                        flag = true;
                    }
                    break;
            }
            if(!flag)
            {
                IKernel kernel = new StandardKernel(new MockInjectionModule(UseMockService));

                ISMSService temp = kernel.Get<ISMSService>();
                temp.SendSMS("01521494586", "Juhan");
            }
            /*else
            {
                ISMSService _SMSService = new SMSService();
                UIHandler _UIHandler = new UIHandler(_SMSService);
                _UIHandler.SendConfirmationMsg("01521494586");
            }*/



            // Hand coded dependency Injection

            /*ISMSService _SMSService = new SMSService();*/
            /* ISMSService _SMSService = new MockSMSService();*/


            //Bydefault dependency Injection

            /*  IKernel _Kernel = new StandardKernel();

              _Kernel.Load(Assembly.GetExecutingAssembly());*/


            //using dependencies with UIhandler

            /*ISMSService _SMSService = new SMSService();
            UIHandler _UIHandler = new UIHandler(_SMSService);
            _UIHandler.SendConfirmationMsg("01521494586");*/



            //Without conditional singleton dependency Injection

            /* IKernel kernel = new StandardKernel(new NinjectBindings());

             SMSService SMS = kernel.Get<SMSService>();
             SMS.SendSMS("01521494587", "Junaid");*/
            /* SMS.NotifyByEmail("01521494586", "Juhan");*/

            //conditional dependency Injection
        }
    }
}

    
