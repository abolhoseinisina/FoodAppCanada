using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApp.Domain.Model
{
    public class Serving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string FoodGroupId { get; set; }

        public string Gender { get; set; }

        public string Age { get; set; }

        public string Servings { get; set; }
    }
}
