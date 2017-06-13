using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Models.Factory.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace MovieTheater.Framework.Core.Commands.Contracts
{
    public class CreateStaffMember : StaffCommand
    {
        public CreateStaffMember(IStaffDbContext dbContext, IModelsFactory modelsFactory) : base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var departmentAsString = parameters[2];

            var department = this.DbContext.Departments.Where(d => d.Name == departmentAsString).ToList()[0];

            var staffmember = this.ModelsFactory.CreateStaffMember(firstName, lastName, department);

            this.DbContext.StaffMembers.Add(staffmember);
            this.DbContext.SaveChanges();

            return $"Successfully created a new StaffMember with ID {staffmember.Id} !";
        }
    }
}
