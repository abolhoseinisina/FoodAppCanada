using FoodApp.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp.Application.Interface
{
    public interface IServingRepository
    {
        public Task<ICollection<Serving>> GetServings();

        public Task<Serving> GetServing(long id);
    }
}
