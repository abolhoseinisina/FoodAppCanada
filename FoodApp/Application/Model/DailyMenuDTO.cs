using System.Collections.Generic;

namespace FoodApp.Application.Model
{
    public class DailyMenuDTO
    {
        public string Age { get; set; }

        public string Gender { get; set; }

        public ICollection<FoodGroupDTO> FoodGroups { get; set; }
    }

    public class FoodGroupDTO
    {
        public string FoodGroupId { get; set; }

        public string FoodGroupName { get; set; }

        public string ServingPerDay { get; set; }

        public ICollection<FoodDTO> Foods { get; set; }

        public ICollection<DirectionDTO> Directions { get; set; }
    }

    public class FoodDTO
    {
        public string FoodCategory { get; set; }

        public string ServingSize { get; set; }

        public string Food { get; set; }
    }

    public class DirectionDTO
    {
        public string Statement { get; set; }
    }
}
