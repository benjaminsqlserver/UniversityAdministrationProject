using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Domain.Entities
{
    public class Relationship
    {
        [Key]
        public Guid RelationshipID { get; set; }
        public string RelationshipName { get; set; }
    }
}
