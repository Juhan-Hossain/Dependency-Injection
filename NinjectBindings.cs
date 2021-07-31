using static DependencyInjection.Program;
using Ninject;
namespace DependencyInjection
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {

            Bind<ISMSService>().To<SMSService>();
            Bind<INotifierService>().To<NotifierService>();

            Bind<ISMSService>().To<MockSMSService>();
            Bind<INotifierService>().To<MockNotifierService>();

        }
    }
}