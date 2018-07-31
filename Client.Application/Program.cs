using ACME.EmplyeeBirthdayWish.CrossCutting.DTO;
using ACME.EmplyeeBirthdayWish.Service.Host.BirthDayServiceHost;
using System;

namespace Client.Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyProxy proxy;
            proxy = new MyProxy();
            
            var checkServiceLink = proxy.CheckConnection();

            if (checkServiceLink == "Service is Up")
            {
                Console.WriteLine("Client is running at " + DateTime.Now.ToString());

                try
                {
                    var result = proxy.GetBirthdays();

                    foreach (Employee record in result)
                    {
                        Console.WriteLine("Happy Birthday {0}\t{1}", record.Name, record.Lastname);
                    }
                    Console.ReadLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
                finally
                {
                    proxy.Close();
                }
            }
            else
            {
                Console.WriteLine("Services are Temporarily Unavailable, Please start ServiceHost and try again");
                Console.ReadLine();
            }
        }
    }
}


