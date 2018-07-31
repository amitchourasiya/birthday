using ACME.EmplyeeBirthdayWish.CrossCutting.DTO;
using ACME.EmplyeeBirthdayWish.Service.Business;
using System;
using System.Collections.Generic;

namespace ACME.EmplyeeBirthdayWish.Service.BirthdayService
{
    public class EmployeeBirthdayService : IGetBirthDayGreeting
    {
        /// <summary>
        /// Find the list of Employess who is having birthday today
        /// </summary>
        /// <returns>retunr the list</returns>
        public List<Employee> GetBirthdays()
        {
            GetBirthday obj = new GetBirthday();
            try
            {
                var result = obj.GetBirthdays();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// this method can be used to get the list of employees who is having Work anniversary today
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetWorkAnniversary()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// dispose method
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// this method to check service is up or down.
        /// </summary>
        /// <returns></returns>
        bool IGetBirthDayGreeting.Ping()
        {
            return true;
        }
    }
}
