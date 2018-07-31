using ACME.EmplyeeBirthdayWish.CrossCutting.DTO;
using ACME.EmplyeeBirthdayWish.Service.Shared.Providers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ACME.EmplyeeBirthdayWish.Service.Business
{
    public class GetBirthday: IBirthday
    {
        public List<Employee> GetBirthdays()
        {
            
            //get allEmployeed list from ACME API
            List<Employee> getAllEmployee = Employees.GetEmployees();

            //get Exclusion list from ACME API
            List<int?> getExlusionList = BirthdayWishExclusion.GetExcluion();
            int count = 0;
            foreach (Employee data in getAllEmployee)
            {
                if (count > 100)
                {
                    data.DateOfBirth = DateTime.Now;
                    data.EmploymentEndDate = DateTime.Now.AddDays(5);
                }
                    count++;
            }

            // applied all considered conditions
            // Employee endDate should not be greater than today
            // Employee Startdate shoule not be less than today
            // Employee Birthday should be Today
            // And Employee should not be in Exclusion list
            //And Employee birth year should not be a leap year. (Assuming that's what in the task description) if that 
            // is not the intention last condition can be removed && (!DateTime.IsLeapYear (a.DateOfBirth.Value.Year)))
            var _result = (from a in getAllEmployee
                       where (a.EmploymentStartDate <= DateTime.Now
                       && a.EmploymentEndDate >= DateTime.Now
                       && !getExlusionList.Contains(a.Id)
                       && (Convert.ToDateTime(a.DateOfBirth).ToShortDateString()) == DateTime.Now.ToShortDateString()
                       && (!DateTime.IsLeapYear (a.DateOfBirth.Value.Year)))
                       select a).ToList();

           
            return _result;

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }

}
