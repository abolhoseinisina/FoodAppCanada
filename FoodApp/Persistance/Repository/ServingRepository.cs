using FoodApp.Application.Interface;
using FoodApp.Domain.Model;
using FoodApp.Persistance.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Persistance.Repository
{
    public class ServingRepository : IServingRepository
    {
        private readonly FoodAppContext context;

        public ServingRepository(FoodAppContext context)
        {
            this.context = context;
        }

        public async Task<Serving> GetServing(long id)
        {
            return await context.Servings.FindAsync(id);
        }

        public async Task<ICollection<Serving>> GetServings()
        {
            return context.Servings.ToList();
        }
    }
}
