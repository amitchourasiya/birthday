using ACME.EmplyeeBirthdayWish.CrossCutting.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACME.EmplyeeBirthdayWish.Service.Shared.Providers
{
    public interface IBirthdayWisherExclusion
    {
       List<EmployeeExclusion> GetExcluion();
    }
}
