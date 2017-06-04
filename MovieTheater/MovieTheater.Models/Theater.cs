using System.Collections.Generic;

namespace MovieTheater.Models
{
    public class Theater
    {
        private ICollection<User> users;
        private ICollection<Movie> movies;

        public Theater()
        {
            this.users = new HashSet<User>();
            this.movies = new HashSet<Movie>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

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
    }
}