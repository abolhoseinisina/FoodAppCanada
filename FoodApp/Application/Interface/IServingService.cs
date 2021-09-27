using FoodApp.Application.Model;
using FoodApp.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp.Application.Interface
{
    public interface IServingService
    {
        public Task<ICollection<Serving>> GetAllServings();

        public Task<ICollection<Serving>> GetProperServings(string gender, string ageRange);

        public Task<ICollection<string>> GetAgeRanges();

        public Task<ICollection<string>> GetGenderRanges();

        public Task<DailyMenuDTO> GetDailyMenu(GenderAge genderAge);

        public Task<FamilyDailyMenuDTO> GetFamilyDailyMenu(List<GenderAge> genderAge);
    }
}
