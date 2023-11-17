using SHB.Application.IRepositories;
using SHB.Domain;

namespace SHB.Infrastructure.Repositories
{
    public class FacultyRepository : GenericRepository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(AppDbContext context) : base(context)
        {

        }
    }
}
