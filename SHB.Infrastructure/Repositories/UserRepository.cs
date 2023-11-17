using Microsoft.EntityFrameworkCore;
using SHB.Application.IRepositories;
using SHB.Domain;

namespace SHB.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }
        public override async Task<User> GetAsync(int id)
        {

            return await _entity
                .Include(a => a.UserType)
                .Include(a => a.Faculty)
                .Include(a => a.FieldOfStudy)
                .Include(a => a.Program)
                .ThenInclude(a => a.Courses)
                    .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public override async Task<IEnumerable<User>> GetAllAsync()
        {

            return await _entity
                .Include(a => a.UserType)
                .Include(a => a.Faculty)
                .Include(a => a.FieldOfStudy)
                .Include(a => a.Program)
                .ThenInclude(a => a.Courses)
                    .AsNoTracking()
                .ToListAsync();
        }
    }
}
