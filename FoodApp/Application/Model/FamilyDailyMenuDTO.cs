using System.Collections.Generic;

namespace FoodApp.Application.Model
{
    public class FamilyDailyMenuDTO
    {
        public ICollection<FamiyFoodGroupDTO> FoodGroups { get; set; }
    }

    public class FamiyFoodGroupDTO
    {
        public string FoodGroupId { get; set; }

        public string FoodGroupName { get; set; }

        public List<FamilyMember> Members { get; set; }

        public ICollection<FoodDTO> Foods { get; set; }

        public ICollection<DirectionDTO> Directions { get; set; }
    }

    public class FamilyMember
    {
        public string Age { get; set; }

        public string Gender { get; set; }

        public string ServingPerDay { get; set; }
    }
}
