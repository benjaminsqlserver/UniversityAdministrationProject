using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace StudentManagement.Domain.Entities
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }

        public string MatriculationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid GenderId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual StudentContactInformation StudentContactInformation { get; set; }
        public virtual ICollection<StudentNextOfKin> StudentNextOfKins { get; set; }
    }
}
