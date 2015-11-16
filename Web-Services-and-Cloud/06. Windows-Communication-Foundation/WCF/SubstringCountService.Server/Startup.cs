namespace SubstringCountService.Server
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    // Note: In order to self host it, run it as administrator - otherwise it will throw an exception!
    public class Startup
    {
        public static void Main()
        {
            // The task requires hosting in IIS, but I did it this way too just for fun.

            var serviceAddress = new Uri("http://localhost:1337/SubstringCount.svc");
            var selfHost = new ServiceHost(typeof(SubstringCountService), serviceAddress);

            var serviceMetaDataBehaviour = new ServiceMetadataBehavior();
            serviceMetaDataBehaviour.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(serviceMetaDataBehaviour);

            selfHost.Open();

            Console.WriteLine("Substring count service listening on {0}", serviceAddress.ToString());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
