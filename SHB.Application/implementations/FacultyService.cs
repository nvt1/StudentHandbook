using AutoMapper;
using SHB.Application.Contract;
using SHB.Application.IRepositories;
using SHB.Application.Models.Request.Faculty;
using SHB.Domain;

namespace SHB.Application.implementations
{
    public class FacultyService : IFacultyService
    {
        private readonly IFacultyRepository _facultyRepository;
        private readonly IMapper _mapper;

        public FacultyService(IFacultyRepository facultyRepository, IMapper mapper)
        {
            _facultyRepository = facultyRepository;
            _mapper = mapper;
        }
        public async Task<Faculty> CreateFacultyAsync(CreateFacultyRequest faculty)
        {
            var createFaculty = _mapper.Map<CreateFacultyRequest, Faculty>(faculty);

            return await _facultyRepository.CreateAsync(createFaculty);
        }

        public async Task DeleteFacultyAsync(int id)
        {
            var faculty = await _facultyRepository.GetAsync(id);
            if (faculty != null)
            {
                await _facultyRepository.DeleteAsync(faculty);
            }
        }

        public async Task<Faculty> GetFacultyByIdAsync(int id)
        {
            return await _facultyRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Faculty>> GetFacultysAsync()
        {
            return await _facultyRepository.GetAllAsync();
        }

        public async Task<Faculty> UpdateFacultyAsync(int id, UpdateFacultyRequest updateFacultyRequest)
        {
            var updateFaculty = await _facultyRepository.GetAsync(id);
            if (updateFaculty != null)
            {
                updateFaculty.Name = updateFacultyRequest?.Name;
                updateFaculty.Description = updateFacultyRequest?.Description;
            }
            return await _facultyRepository.UpdateAsync(updateFaculty);
        }
    }
}
