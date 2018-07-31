using Newtonsoft.Json;
using System;

namespace ACME.EmplyeeBirthdayWish.CrossCutting.DTO
{
    public class EmployeeExclusion
    {
       
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }


    }
}
