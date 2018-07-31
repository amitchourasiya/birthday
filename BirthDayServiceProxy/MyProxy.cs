using ACME.EmplyeeBirthdayWish.CrossCutting.DTO;
using ACME.EmplyeeBirthdayWish.Service.BirthdayService;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ACME.EmplyeeBirthdayWish.Service.Host.BirthDayServiceHost
{
    public class MyProxy : ClientBase<IGetBirthDayGreeting>
    {  
        public List<Employee> GetBirthdays()
        {
            try
            {
                return Channel.GetBirthdays();
            }
            catch (FaultException ex)
            {
                throw ex;
            }
        }

        public List<Employee> GetWorkAnniversary()
        {
            throw new NotImplementedException();
        }

        public string CheckConnection()
        {
            try
            {
                var status = Ping();
                if (status)
                    return "Service is Up";
            }
            catch (Exception ex)
            {               
                return "Service is Down";
            }
            return "Service is Down";
        }
        bool Ping()
        {
            return Channel.Ping();
        }
    }
}
