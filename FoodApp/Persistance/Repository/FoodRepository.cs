using FoodApp.Application.Interface;
using FoodApp.Domain.Model;
using FoodApp.Persistance.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Persistance.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private readonly FoodAppContext context;

        public FoodRepository(FoodAppContext context)
        {
            this.context = context;
        }

        public async Task<Food> GetFood(long id)
        {
            return await context.Foods.FindAsync(id);
        }

        public async Task<ICollection<Food>> GetFoods()
        {
            return context.Foods.ToList();
        }
    }
}
