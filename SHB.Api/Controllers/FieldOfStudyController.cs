using Microsoft.AspNetCore.Mvc;
using SHB.Application.Contract;
using SHB.Application.Models.Request.FieldOfStudy;
using SHB.Domain;

namespace SHB.Api.Controllers
{
    [ApiController]
    [Route("api/fieldOfStudy")]
    public class FieldOfStudyController : ControllerBase
    {
        private readonly IFieldOfStudyService _fieldOfStudyService;

        public FieldOfStudyController(IFieldOfStudyService fieldOfStudyService)
        {
            _fieldOfStudyService = fieldOfStudyService;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<FieldOfStudy>> CreateFieldOfStudyAsync(CreateFieldOfStudyRequest fieldOfStudy)
        {
            var result = await _fieldOfStudyService.CreateFieldOfStudyAsync(fieldOfStudy);
            return Ok(result);
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<FieldOfStudy>> UpdateFieldOfStudyAsync(int id, UpdateFieldOfStudyRequest updateFieldOfStudyRequest)
        {
            var result = await _fieldOfStudyService.UpdateFieldOfStudyAsync(id, updateFieldOfStudyRequest);
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<FieldOfStudy>> GetFieldOfStudyIdAsync(int id)
        {
            var result = await _fieldOfStudyService.GetFieldOfStudyByIdAsync(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteFieldOfStudyAsync(int id)
        {
            try
            {
                await _fieldOfStudyService.DeleteFieldOfStudyAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<FieldOfStudy>>> GetFieldOfStudysAsync()
        {
            var result = await _fieldOfStudyService.GetFieldOfStudysAsync();
            return Ok(result);
        }
    }
}
