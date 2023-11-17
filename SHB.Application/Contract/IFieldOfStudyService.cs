using SHB.Application.Models.Request.FieldOfStudy;
using SHB.Domain;

namespace SHB.Application.Contract
{
    public interface IFieldOfStudyService
    {
        Task<IEnumerable<FieldOfStudy>> GetFieldOfStudysAsync();

        Task<FieldOfStudy> GetFieldOfStudyByIdAsync(int id);

        Task<FieldOfStudy> UpdateFieldOfStudyAsync(int id, UpdateFieldOfStudyRequest updateFieldOfStudyRequest);

        Task<FieldOfStudy> CreateFieldOfStudyAsync(CreateFieldOfStudyRequest fieldOfStudy);

        Task DeleteFieldOfStudyAsync(int id);
    }
}
