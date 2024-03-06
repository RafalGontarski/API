using API.Domain.Dtos;
using API.Domain.Entities;
using API.Services.Abstractions.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthorizeController(IUserService userService) : ControllerBase
    {
        [HttpPost]
        public User? Register(UserRegisterDto model)
        {
            if (ModelState.IsValid)
            {
                return userService.Register(model);
            }
            return null;
        }

        [HttpPost]
        public User? Login(UserLoginDto model)
        {
            if (ModelState.IsValid)
            {
                return userService.Login(model);
            }
            return null;
        }
    }
}
