using FoodApp.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp.Application.Interface
{
    public interface IFoodGroupRepository
    {
        public Task<ICollection<FoodGroup>> GetFoodGroups();

        public Task<FoodGroup> GetFoodGroup(long id);
    }
}
