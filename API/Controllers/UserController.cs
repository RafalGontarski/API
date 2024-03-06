using API.Domain.Dtos;
using API.Services.Abstractions.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize("Admin")]
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController(IUserService userService) : ControllerBase
    {
    }
}
