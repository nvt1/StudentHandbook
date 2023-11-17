using SHB.Application.IRepositories;
using SHB.Domain;

namespace SHB.Infrastructure.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base(context)
        {

        }
    }
}
