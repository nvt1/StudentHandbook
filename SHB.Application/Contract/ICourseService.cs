using SHB.Application.Models.Request.Course;
using SHB.Domain;

namespace SHB.Application.Contract
{
    public interface ICourseService
    {

        Task<IEnumerable<Course>> GetCoursesAsync();

        Task<Course> GetCourseByIdAsync(int id);

        Task<Course> UpdateCourseAsync(int id, UpdateCourseRequest updateCourseRequest);

        Task<Course> CreateCourseAsync(CreateCourseRequest course);

        Task DeleteCourseAsync(int id);
    }
}
