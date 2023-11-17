using AutoMapper;
using SHB.Application.Contract;
using SHB.Application.IRepositories;
using SHB.Application.Models.Request.Course;
using SHB.Domain;

namespace SHB.Application.implementations
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public async Task<Course> CreateCourseAsync(CreateCourseRequest course)
        {
            var createCourse = _mapper.Map<CreateCourseRequest, Course>(course);

            return await _courseRepository.CreateAsync(createCourse);
        }

        public async Task DeleteCourseAsync(int id)
        {
            var course = await _courseRepository.GetAsync(id);
            if (course != null)
            {
                await _courseRepository.DeleteAsync(course);
            }
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            return await _courseRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            return await _courseRepository.GetAllAsync();
        }

        public async Task<Course> UpdateCourseAsync(int id, UpdateCourseRequest updateCourseRequest)
        {
            var updateCourse = await _courseRepository.GetAsync(id);
            if (updateCourse != null)
            {
                updateCourse.CourseCode = updateCourseRequest?.CourseCode;
                updateCourse.Name = updateCourseRequest?.Name;
                updateCourse.PracticalHours = updateCourseRequest?.PracticalHours;
                updateCourse.TheoreticalHours = updateCourseRequest?.TheoreticalHours;
                updateCourse.Semester = updateCourseRequest?.Semester;
                updateCourse.ProgramId = updateCourseRequest?.ProgramId;
            }
            return await _courseRepository.UpdateAsync(updateCourse);
        }
    }
}
