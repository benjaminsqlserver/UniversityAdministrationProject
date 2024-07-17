using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Domain.Entities
{
    public class Country
    {
        [Key]
        public Guid CountryID { get; set; }
        public string CountryName { get; set; }
    }
}
