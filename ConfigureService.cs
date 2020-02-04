using Topshelf;

namespace ApplicationExampleTopShelf
{
    public class ConfigureService
    {
        internal static void Configure()
        {
            const string nameofDescription = "My Service Windows to TopShelf";
            HostFactory.Run(configure =>
            {
                configure.Service<MyServiceWS>(service =>
                {
                    service.ConstructUsing(s => new MyServiceWS());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });

                configure.RunAsLocalSystem();
                configure.SetServiceName(nameofDescription);
                configure.SetDisplayName(nameofDescription);
                configure.SetDescription(nameofDescription);
            });
        }
    }
}
