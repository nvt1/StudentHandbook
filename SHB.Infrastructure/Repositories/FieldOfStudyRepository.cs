using SHB.Application.IRepositories;
using SHB.Domain;

namespace SHB.Infrastructure.Repositories
{
    public class FieldOfStudyRepository : GenericRepository<FieldOfStudy>, IFieldOfStudyRepository
    {
        public FieldOfStudyRepository(AppDbContext context) : base(context)
        {

        }
    }
}
