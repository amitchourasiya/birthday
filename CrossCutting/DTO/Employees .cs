using Newtonsoft.Json;
using System;

namespace ACME.EmplyeeBirthdayWish.CrossCutting.DTO
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Employee
    {
        /// <summary>
        /// Initializes a new instance of the Employee class.
        /// </summary>
        public Employee() { }

        /// <summary>
        /// Initializes a new instance of the Employee class.
        /// </summary>
        public Employee(int? id = default(int?), string name = default(string), string lastname = default(string), DateTime? dateOfBirth = default(DateTime?), DateTime? employmentStartDate = default(DateTime?), DateTime? employmentEndDate = default(DateTime?))
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
            EmploymentStartDate = employmentStartDate;
            EmploymentEndDate = employmentEndDate;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "employmentStartDate")]
        public DateTime? EmploymentStartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "employmentEndDate")]
        public DateTime? EmploymentEndDate { get; set; }

    }
}
