using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Domain.Entities
{
    public class NextOfKinContactInformation
    {
        [Key]
        public Guid NextOfKinContactID { get; set; }
        public string HouseAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Guid CountryID { get; set; }
        public Guid NextOfKinID { get; set; }
        public virtual Country Country { get; set; }
        public virtual StudentNextOfKin StudentNextOfKin { get; set; }
    }
}
