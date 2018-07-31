using ACME.EmplyeeBirthdayWish.Service.BirthdayService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.EmplyeeBirthdayWish.Service.Business;

namespace Service.Test
{
    [TestClass]
    public class BirthDayServiceTest
    {
        private EmployeeBirthdayService _birthDayService;
        private WorkAnniversary _workAnniversary;


        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
                
        [TestMethod]
        public void GetEmployee()
        {
            var _employeeGetAll = Employees.GetEmployees();            
            Assert.IsNotNull(_employeeGetAll);
            
        }

        [TestMethod]
        public void GetBirthday()
        {
            _birthDayService = new EmployeeBirthdayService();
            var _getBirthday = _birthDayService.GetBirthdays();
            Assert.IsNotNull(_getBirthday);

        }

        [TestMethod]
        public void GetWorkAnnNegative()
        {
            _workAnniversary = new WorkAnniversary();
            try
            {
                var _getWorkAnn = _workAnniversary.GetWorkAnniversary();
            }
            catch (System.NotImplementedException ex)
            {
                Assert.Fail("Not Implemented");
            }
            
        }

        [TestMethod]
        public void GetEmployeeExclusion()
        {
            var _birthDayExclusion = BirthdayWishExclusion.GetExcluion();
            Assert.IsNotNull(_birthDayExclusion);         
        }
        
    }
}
