using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Domain.Entities
{
    public class Gender
    {
        [Key]
        public Guid GenderID { get; set; }
        public string GenderName { get; set; }
    }
}
