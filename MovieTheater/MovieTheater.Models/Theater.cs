using System.Collections.Generic;

namespace MovieTheater.Models
{
    public class Theater
    {
        private ICollection<User> users;

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users
        {
            get { return this.users; }
        }
    }
}