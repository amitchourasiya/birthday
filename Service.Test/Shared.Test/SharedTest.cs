using ACME.EmplyeeBirthdayWish.Service.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Test.Shared.Test
{
    [TestClass]
    public class SharedTest
    {
        [TestMethod]
        public void BuildUriSuccess ()
        {
            var baseUrl = "https://Acmesoft/utilities/";
            var api = "swagger/workAnneversary";

            var result = ExtensionMethods.BuildURL(baseUrl, api);            
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BuildUriFailure()
        {
            var baseUrl = "https:\\Acmesoft//utilities\\";
            var api = "swagger/workAnneversary";

            try
            {
                var result = ExtensionMethods.BuildURL(baseUrl, api);
            }
            catch(System.UriFormatException ex)
            {
                Assert.Fail(ex.Message);
            }
            
        }

    }
}
