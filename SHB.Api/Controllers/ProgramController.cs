using Microsoft.AspNetCore.Mvc;
using SHB.Application.Contract;
using SHB.Application.Models.Request.Program;

namespace SHB.Api.Controllers
{
    [ApiController]
    [Route("api/program")]
    public class ProgramController : ControllerBase
    {
        private readonly IProgramService _programService;

        public ProgramController(IProgramService programService)
        {
            _programService = programService;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<SHB.Domain.Program>> CreateProgramAsync(CreateProgramRequest program)
        {
            var result = await _programService.CreateProgramAsync(program);
            return Ok(result);
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<SHB.Domain.Program>> UpdateProgramAsync(int id, UpdateProgramRequest updateProgramRequest)
        {
            var result = await _programService.UpdateProgramAsync(id, updateProgramRequest);
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<SHB.Domain.Program>> GetProgramIdAsync(int id)
        {
            var result = await _programService.GetProgramByIdAsync(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteProgramAsync(int id)
        {
            try
            {
                await _programService.DeleteProgramAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<SHB.Domain.Program>>> GetProgramsAsync()
        {
            var result = await _programService.GetProgramsAsync();
            return Ok(result);
        }
    }
}
