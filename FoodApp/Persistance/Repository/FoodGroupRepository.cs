using FoodApp.Application.Interface;
using FoodApp.Domain.Model;
using FoodApp.Persistance.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Persistance.Repository
{
    public class FoodGroupRepository : IFoodGroupRepository
    {
        private readonly FoodAppContext context;

        public FoodGroupRepository(FoodAppContext context)
        {
            this.context = context;
        }

        public async Task<FoodGroup> GetFoodGroup(long id)
        {
            return await context.FoodGroups.FindAsync(id);
        }

        public async Task<ICollection<FoodGroup>> GetFoodGroups()
        {
            return context.FoodGroups.ToList();
        }
    }
}
