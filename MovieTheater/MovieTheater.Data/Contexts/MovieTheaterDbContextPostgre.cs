using MovieTheater.Data.Contracts;
using MovieTheater.Models;
using System.Data.Entity;

namespace MovieTheater.Data.Contexts
{
    public class MovieTheaterDbContextPostgre : DbContext, IStaffDbContext
    {
        public MovieTheaterDbContextPostgre() : base("MovieTheaterPostgre")
        {

        }

        public IDbSet<StaffMember> StaffMembers { get; set; }

        public IDbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.OnDepartmentModelCreating(modelBuilder);
            this.OnStaffMemberModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void OnStaffMemberModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffMember>()
                .HasKey(s => s.Id)
                .HasRequired(s => s.Department);

            modelBuilder.Entity<StaffMember>()
                .Property(s => s.FirstName)
                .IsRequired()
                .HasColumnType("varchar");


            modelBuilder.Entity<StaffMember>()
                .Property(s => s.LastName)
                .IsRequired()
                .HasColumnType("varchar");
        }

        private void OnDepartmentModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Department>()
                .Property(d => d.Name)
                .IsRequired()
                .HasColumnType("varchar");
        }
    }
}
