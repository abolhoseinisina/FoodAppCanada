using FoodApp.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp.Application.Interface
{
    public interface IFoodRepository
    {
        public Task<ICollection<Food>> GetFoods();

        public Task<Food> GetFood(long id);
    }
}
