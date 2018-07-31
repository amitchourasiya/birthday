using ACME.EmplyeeBirthdayWish.CrossCutting.DTO;
using System;
using System.Collections.Generic;

namespace ACME.EmplyeeBirthdayWish.Service.Shared.Providers
{
    public interface IWorkAnniversary: IDisposable
    {
        List<Employee> GetWorkAnniversary();
    }
}
