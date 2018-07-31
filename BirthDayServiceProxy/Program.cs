using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ACME.EmplyeeBirthdayWish.Service.Host.BirthDayServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri(ConfigurationManager.AppSettings["Uri"]);
            
            //Create ServiceHost
            ServiceHost _host = new ServiceHost(typeof(BirthdayService.EmployeeBirthdayService), httpUrl);

            //Add a service endpoint
            _host.AddServiceEndpoint(typeof(BirthdayService.IGetBirthDayGreeting), new WSHttpBinding(), "");
            
            //Enable metadata exchange
            ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
            serviceMetadataBehavior.HttpGetEnabled = true;
            _host.Description.Behaviors.Add(serviceMetadataBehavior);
            
            //Start the Service
            try
            {
                _host.Open();

                Console.WriteLine("Service is host at " + DateTime.Now.ToString());
                Console.WriteLine("Host is running... Press <Enter> key to stop");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _host.Close();
            }
        }
    }
}
