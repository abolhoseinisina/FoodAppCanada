using FoodApp.Application.Interface;
using FoodApp.Domain.Model;
using FoodApp.Persistance.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Persistance.Repository
{
    public class StatementRepository : IStatementRepository
    {
        private readonly FoodAppContext context;

        public StatementRepository(FoodAppContext context)
        {
            this.context = context;
        }

        public async Task<Statement> GetStatement(long id)
        {
            return await context.Statements.FindAsync(id);
        }

        public async Task<ICollection<Statement>> GetStatements()
        {
            return context.Statements.ToList();
        }
    }
}
