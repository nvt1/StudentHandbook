using AutoMapper;
using SHB.Application.Contract;
using SHB.Application.IRepositories;
using SHB.Application.Models.Request.Program;
using SHB.Domain;

namespace SHB.Application.implementations
{
    public class ProgramService : IProgramService
    {
        private readonly IProgramRepository _programRepository;
        private readonly IMapper _mapper;

        public ProgramService(IProgramRepository programRepository, IMapper mapper)
        {
            _programRepository = programRepository;
            _mapper = mapper;
        }
        public async Task<Program> CreateProgramAsync(CreateProgramRequest program)
        {
            var createProgram = _mapper.Map<CreateProgramRequest, Program>(program);

            return await _programRepository.CreateAsync(createProgram);
        }

        public async Task DeleteProgramAsync(int id)
        {
            var program = await _programRepository.GetAsync(id);
            if (program != null)
            {
                await _programRepository.DeleteAsync(program);
            }
        }

        public async Task<Program> GetProgramByIdAsync(int id)
        {
            return await _programRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Program>> GetProgramsAsync()
        {
            return await _programRepository.GetAllAsync();
        }

        public async Task<Program> UpdateProgramAsync(int id, UpdateProgramRequest updateProgramRequest)
        {
            var updateProgram = await _programRepository.GetAsync(id);
            if (updateProgram != null)
            {
                updateProgram.Name = updateProgramRequest?.Name;
                updateProgram.Year = updateProgramRequest?.Year;
                updateProgram.FieldOfStudyId = updateProgramRequest?.FieldOfStudyId;
            }
            return await _programRepository.UpdateAsync(updateProgram);
        }
    }
}
