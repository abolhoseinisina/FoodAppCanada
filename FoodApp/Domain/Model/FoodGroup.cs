using System.ComponentModel.DataAnnotations;

namespace FoodApp.Domain.Model
{
    public class FoodGroup
    {
        [Key]
        public long Id { get; set; }

        public string FoodGroupId { get; set; }

        public string FoodGroupName { get; set; }

        public int FoodGroupCategoryId { get; set; }

        public string FoodGroupCategoryName { get; set; }
    }
}
