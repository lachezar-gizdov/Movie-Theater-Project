using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Framework.Core.Commands.Contracts;
using System;
using System.Collections.Generic;
using MovieTheater.Data.Contracts;
using MovieTheater.Models.Factory.Contracts;
using System.Linq;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateHallScheduleCommand : Command, ICommand
    {
        public CreateHallScheduleCommand(IMovieTheaterDbContext dbContext, IModelsFactory modelsFactory) 
            : base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {
            if (parameters.Any(x => x == string.Empty))
            {
                throw new Exception("Some of the passed parameters are empty!");
            }

            var hallScheduleNumber = parameters[0];
            var hallNumber = parameters[1];
            var hall = this.DbContext.Halls.FirstOrDefault(t => t.Number == hallNumber);

            if (hall == null)
            {
                throw new ArgumentException("The Hall does not exist!");
            }

            var hallSchedule = this.DbContext.HallShedules.FirstOrDefault(h => h.Number == hallScheduleNumber);

            if (hallSchedule != null)
            {
                throw new ArgumentException("This hall exist!");
            }

            var newHallSchedule = this.ModelsFactory.CreateHallSchedule(hallScheduleNumber, hall);
            this.DbContext.HallShedules.Add(newHallSchedule);
            this.DbContext.SaveChanges();

            return $"Successfully created a new HallSchedule with ID {newHallSchedule.Id} !";
        }
    }
}