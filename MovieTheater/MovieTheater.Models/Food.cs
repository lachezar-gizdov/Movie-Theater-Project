using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTheater.Models
{
    public class Food
    {
        public int Id { get; set; }

        [Index("IX_FoodUnique", IsUnique = true)]
        [MaxLength(50), MinLength(2)]
        public string Name { get; set; }

        public virtual ICollection<FoodShop> Shops { get; set; }
    }
}