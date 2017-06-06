using MovieTheater.Framework.Models.Contracts;

namespace MovieTheater.Framework.Models
{
    public class Theater : ITheater
    {
        public Theater(string theaterName)
        {
            this.TheaterName = theaterName;
        }

        public int Id
        {
            get;

            set;
        }

        public string TheaterName
        {
            get;

            set;
        }
    }
}