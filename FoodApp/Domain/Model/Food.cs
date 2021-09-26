using System.ComponentModel.DataAnnotations;

namespace FoodApp.Domain.Model
{
    public class Food
    {
        [Key]
        public long Id { get; set; }

        public string FoodGroupId { get; set; }

        public int FoodGroupCategory { get; set; }

        public string ServingSize { get; set; }

        public string Foods { get; set; }
    }
}
