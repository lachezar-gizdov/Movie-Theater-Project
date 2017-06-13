using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTheater.Models
{
    public class FoodShop
    {
        public int Id { get; set; }

        [MaxLength(50), MinLength(2)]
        public string Name { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
