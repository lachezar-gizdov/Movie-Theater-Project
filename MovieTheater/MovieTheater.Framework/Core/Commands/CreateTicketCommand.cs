using System;
using System.Collections.Generic;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;
using System.Linq;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateTicketCommand : Command, ICommand
    {
        public CreateTicketCommand(IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory) : 
            base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {

            if (parameters.Any(x => x == string.Empty))
            {
                throw new Exception("Some of the passed parameters are empty!");
            }

            var ticketId = Int32.Parse(parameters[0]);
            var movieName = parameters[1];
            var scheduleName = parameters[2];
            var price = decimal.Parse(parameters[3]);
            var userName = parameters[4];
            var seat = Int32.Parse(parameters[5]);

            var movie = this.DbContext.Movies.FirstOrDefault(m => m.Title == movieName);
            var schedule = this.DbContext.HallShedules.FirstOrDefault(h => h.Number == scheduleName);
            var user = this.DbContext.Users.FirstOrDefault(u => u.FirstName == userName);

            if (movie == null || schedule == null || user == null)
            {
                throw new ArgumentException("The Parameter does not exist!");
            }

            var ticket = this.DbContext.Tickets.FirstOrDefault(t => t.Id == ticketId);

            if (ticket != null)
            {
                throw new ArgumentException("This ticket exist!");
            }

            var newTicket = this.ModelsFactory.CreateTicket(ticketId, movie,schedule,price,user,seat);
            this.DbContext.Tickets.Add(newTicket);
            this.DbContext.SaveChanges();

            return $"Successfully created a new Ticket with ID {newTicket.Id} !";
        }
    }
}