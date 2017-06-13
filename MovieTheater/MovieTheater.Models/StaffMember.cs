using System.ComponentModel.DataAnnotations;

namespace MovieTheater.Models
{
    public class StaffMember
    {
        public int Id { get; set; }

        [MaxLength(50), MinLength(2)]
        public string FirstName { get; set; }

        [MaxLength(50), MinLength(2)]
        public string LastName { get; set; }

        public virtual Department Department { get; set;  }
    }
}
