using MovieTheater.Models;
using System.Data.Entity;

namespace MovieTheater.Data.Contracts
{
    public interface IStaffDbContext
    {
        IDbSet<Department> Departments { get; set; }

        IDbSet<StaffMember> StaffMembers { get; set; }

        int SaveChanges();
    }
}
