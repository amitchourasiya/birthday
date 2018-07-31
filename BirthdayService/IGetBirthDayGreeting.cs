using ACME.EmplyeeBirthdayWish.CrossCutting.DTO;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ACME.EmplyeeBirthdayWish.Service.BirthdayService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGetBirthDayGreeting:IDisposable
    {
        //[OperationContract]
        //List<Employee> GetAllEmployee();

        //[OperationContract]
        //List<int?> GetAllEmployeeExclusion();


        [OperationContract]
        bool Ping();

        /// <summary>
        /// Interfact to get the list of Employees who is having birthday Today
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Employee> GetBirthdays();

        [OperationContract]
        List<Employee> GetWorkAnniversary();


    }


   
}
