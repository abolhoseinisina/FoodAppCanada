using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Application.Model
{
    public class DailyMenuDTO
    {
        public string Age { get; set; }

        public string Gender { get; set; }

        public ICollection<Meal> Meals { get; set; }

        public ICollection<Direction> Directions { get; set; }
    }

    public class Direction
    {
        public string FoodGroupId { get; set; }

        public string Statement { get; set; }
    }

    public class Meal
    {
        public string FoodGroupId { get; set; }

        public string FoodGroup { get; set; }

        public string ServingSize { get; set; }

        public string Food { get; set; }
    }
}
