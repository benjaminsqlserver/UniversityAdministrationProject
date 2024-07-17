using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Domain.Entities
{
    public class StudentNextOfKin
    {
        [Key]
        public Guid NextOfKinID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid GenderId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid StudentID { get; set; }
        public Guid RelationshipID { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Student Student { get; set; }
        public virtual Relationship Relationship { get; set; }
        public virtual NextOfKinContactInformation NextOfKinContactInformation { get; set; }
    }
}
