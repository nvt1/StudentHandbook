using Microsoft.AspNetCore.Mvc;
using SHB.Application.Contract;
using SHB.Application.Models.Request.Faculty;
using SHB.Domain;

namespace SHB.Api.Controllers
{
    [ApiController]
    [Route("api/faculty")]
    public class FacultyController : ControllerBase
    {
        private readonly IFacultyService _facultyService;

        public FacultyController(IFacultyService facultyService)
        {
            _facultyService = facultyService;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Faculty>> CreateFacultyAsync(CreateFacultyRequest faculty)
        {
            var result = await _facultyService.CreateFacultyAsync(faculty);
            return Ok(result);
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Faculty>> UpdateFacultyAsync(int id, UpdateFacultyRequest updateFacultyRequest)
        {
            var result = await _facultyService.UpdateFacultyAsync(id, updateFacultyRequest);
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Faculty>> GetFacultyIdAsync(int id)
        {
            var result = await _facultyService.GetFacultyByIdAsync(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteFacultyAsync(int id)
        {
            try
            {
                await _facultyService.DeleteFacultyAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<Faculty>>> GetFacultysAsync()
        {
            var result = await _facultyService.GetFacultysAsync();
            return Ok(result);
        }
    }
}
