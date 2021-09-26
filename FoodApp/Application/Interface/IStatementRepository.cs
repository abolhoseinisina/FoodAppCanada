using FoodApp.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp.Application.Interface
{
    public interface IStatementRepository
    {
        public Task<ICollection<Statement>> GetStatements();

        public Task<Statement> GetStatement(long id);
    }
}
