using Microsoft.AspNetCore.Mvc;
using SHB.Application.Contract;
using SHB.Application.Models.Request.User;
using SHB.Domain;

namespace SHB.Api.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<User>> CreateUserAsync(CreateUserRequest user)
        {
            var result = await _userService.CreateUserAsync(user);
            return Ok(result);
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<User>> UpdateUserAsync(int id, UpdateUserRequest updateUserRequest)
        {
            var result = await _userService.UpdateUserAsync(id, updateUserRequest);
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<User>> GetUserIdAsync(int id)
        {
            var result = await _userService.GetUserByIdAsync(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteUserAsync(int id)
        {
            try
            {
                await _userService.DeleteUserAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsersAsync()
        {
            var result = await _userService.GetUsersAsync();
            return Ok(result);
        }
    }
}
