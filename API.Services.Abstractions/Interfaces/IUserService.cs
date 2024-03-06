using API.Domain.Dtos;
using API.Domain.Entities;

namespace API.Services.Abstractions.Interfaces
{
    public interface IUserService
    {
        User Register(UserRegisterDto model);
        User Login(UserLoginDto model);
    }
}
