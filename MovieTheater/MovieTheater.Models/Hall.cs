using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace MovieTheater.Models
{ 
    public class Hall
    {
        private readonly int seats;
        private ICollection<HallSchedule> hallSchedules;  

        public Hall()
        {
            seats = 80;
            this.HallSchedules = new HashSet<HallSchedule>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Theater Theater { get; set; }

        public int Seats
        {
            get
            {
                return this.seats;
            }         
        }

        public virtual ICollection<HallSchedule> HallSchedules
        {
            get
            {
                return this.hallSchedules;
            }
            set
            {
                this.hallSchedules = value;
            }
        }
       
    }
}