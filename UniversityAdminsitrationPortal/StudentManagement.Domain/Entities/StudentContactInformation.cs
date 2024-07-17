using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace StudentManagement.Domain.Entities
{
    public class StudentContactInformation
    {
        [Key]
        public Guid StudentContactID { get; set; }
        public string HouseAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Guid CountryID { get; set; }
        public Guid StudentID { get; set; }
        public virtual Country Country { get; set; }
        public virtual Student Student { get; set; }
    }
}
