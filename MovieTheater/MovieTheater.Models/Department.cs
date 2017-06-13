using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTheater.Models
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50), MinLength(2)]
        [Index("IX_DepartmentUnique", IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<StaffMember> StaffMembers { get; set; }
    }
}