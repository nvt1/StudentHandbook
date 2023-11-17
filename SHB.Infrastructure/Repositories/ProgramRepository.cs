using SHB.Application.IRepositories;
using SHB.Domain;

namespace SHB.Infrastructure.Repositories
{
    public class ProgramRepository : GenericRepository<Program>, IProgramRepository
    {
        public ProgramRepository(AppDbContext context) : base(context)
        {

        }
    }
}
