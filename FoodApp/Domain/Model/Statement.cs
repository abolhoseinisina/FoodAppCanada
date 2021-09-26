using System.ComponentModel.DataAnnotations;

namespace FoodApp.Domain.Model
{
    public class Statement
    {
        [Key]
        public long Id { get; set; }

        public string FoodGroupId { get; set; }

        public string DirectionalStatement { get; set; }
    }
}
