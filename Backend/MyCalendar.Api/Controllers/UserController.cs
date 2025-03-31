using Microsoft.AspNetCore.Mvc;
using MyCalendar.Application.Interfaces.Services;
using MyCalendar.Domain.DTOs.User;
using MyCalendar.Domain.Entities;

namespace MyCalendar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserInterface _userInterface;
        public UserController(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult<Response<User>>> CreateUser(UserCreateDTO userDTO)
        {
            var response = await _userInterface.CreateUser(userDTO);
            return Ok(response);
        }
    }
}
