using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTheater.Models
{
    public class Theater
    {
        private ICollection<User> users;
        private ICollection<Movie> movies;
        private ICollection<Hall> halls;

        public Theater()
        {
            this.Users = new HashSet<User>();
            this.Movies = new HashSet<Movie>();
            this.Halls = new HashSet<Hall>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public virtual City City { get; set; }

        public virtual ICollection<User> Users
        {
            get
            {
                return this.users;
            }

            set
            {
                this.users = value;
            }
        }

        public virtual ICollection<Movie> Movies
        {
            get
            {
                return this.movies;
            }

            set
            {
                this.movies = value;
            }
        }

        public virtual ICollection<Hall> Halls
        {
            get
            {
                return this.halls;
            }

            set
            {
                this.halls = value;
            }
        }
    }
}