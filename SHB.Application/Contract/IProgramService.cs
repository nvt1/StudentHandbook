using SHB.Application.Models.Request.Program;
using SHB.Domain;

namespace SHB.Application.Contract
{
    public interface IProgramService
    {
        Task<IEnumerable<Program>> GetProgramsAsync();

        Task<Program> GetProgramByIdAsync(int id);

        Task<Program> UpdateProgramAsync(int id, UpdateProgramRequest updateProgramRequest);

        Task<Program> CreateProgramAsync(CreateProgramRequest program);

        Task DeleteProgramAsync(int id);
    }
}
