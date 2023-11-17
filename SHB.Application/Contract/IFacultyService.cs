using SHB.Application.Models.Request.Faculty;
using SHB.Domain;

namespace SHB.Application.Contract
{
    public interface IFacultyService
    {
        Task<IEnumerable<Faculty>> GetFacultysAsync();

        Task<Faculty> GetFacultyByIdAsync(int id);

        Task<Faculty> UpdateFacultyAsync(int id, UpdateFacultyRequest updateFacultyRequest);

        Task<Faculty> CreateFacultyAsync(CreateFacultyRequest faculty);

        Task DeleteFacultyAsync(int id);
    }
}
