using AutoMapper;
using SHB.Application.Contract;
using SHB.Application.IRepositories;
using SHB.Application.Models.Request.FieldOfStudy;
using SHB.Domain;

namespace SHB.Application.implementations
{
    public class FieldOfStudyService : IFieldOfStudyService
    {
        private readonly IFieldOfStudyRepository _fieldOfStudyRepository;
        private readonly IMapper _mapper;

        public FieldOfStudyService(IFieldOfStudyRepository fieldOfStudyRepository, IMapper mapper)
        {
            _fieldOfStudyRepository = fieldOfStudyRepository;
            _mapper = mapper;
        }
        public async Task<FieldOfStudy> CreateFieldOfStudyAsync(CreateFieldOfStudyRequest fieldOfStudy)
        {
            var createFieldOfStudy = _mapper.Map<CreateFieldOfStudyRequest, FieldOfStudy>(fieldOfStudy);

            return await _fieldOfStudyRepository.CreateAsync(createFieldOfStudy);
        }

        public async Task DeleteFieldOfStudyAsync(int id)
        {
            var fieldOfStudy = await _fieldOfStudyRepository.GetAsync(id);
            if (fieldOfStudy != null)
            {
                await _fieldOfStudyRepository.DeleteAsync(fieldOfStudy);
            }
        }

        public async Task<FieldOfStudy> GetFieldOfStudyByIdAsync(int id)
        {
            return await _fieldOfStudyRepository.GetAsync(id);
        }

        public async Task<IEnumerable<FieldOfStudy>> GetFieldOfStudysAsync()
        {
            return await _fieldOfStudyRepository.GetAllAsync();
        }

        public async Task<FieldOfStudy> UpdateFieldOfStudyAsync(int id, UpdateFieldOfStudyRequest updateFieldOfStudyRequest)
        {
            var updateFieldOfStudy = await _fieldOfStudyRepository.GetAsync(id);
            if (updateFieldOfStudy != null)
            {
                updateFieldOfStudy.Name = updateFieldOfStudyRequest?.Name;
                updateFieldOfStudy.FacultyId = updateFieldOfStudyRequest?.FacultyId;
            }
            return await _fieldOfStudyRepository.UpdateAsync(updateFieldOfStudy);
        }
    }
}
