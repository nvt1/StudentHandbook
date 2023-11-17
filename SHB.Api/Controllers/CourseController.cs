using Microsoft.AspNetCore.Mvc;
using SHB.Application.Contract;
using SHB.Application.Models.Request.Course;
using SHB.Domain;

namespace SHB.Api.Controllers
{
    [ApiController]
    [Route("api/course")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Course>> CreateCourseAsync(CreateCourseRequest course)
        {
            var result = await _courseService.CreateCourseAsync(course);
            return Ok(result);
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Course>> UpdateCourseAsync(int id, UpdateCourseRequest updateCourseRequest)
        {
            var result = await _courseService.UpdateCourseAsync(id, updateCourseRequest);
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Course>> GetCourseIdAsync(int id)
        {
            var result = await _courseService.GetCourseByIdAsync(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteCourseAsync(int id)
        {
            try
            {
                await _courseService.DeleteCourseAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<Course>>> GetCoursesAsync()
        {
            var result = await _courseService.GetCoursesAsync();
            return Ok(result);
        }
    }
}
