using API.Database.EntityFramework.Domain;
using API.Domain.Dtos;
using API.Domain.Entities;
using API.Domain.Enums;
using API.Services.Abstractions.Interfaces;

namespace API.Services.Implementations
{
    public class UserService(AppDbContext context) : IUserService
    {
        User IUserService.Register(UserRegisterDto model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var user = new User
            {
                Email = model.Email,
                Password = model.Password,
            };

            context.Users.Add(user);
            context.SaveChanges();

            var roleId = context.Roles
                .Where(x => x.Name == Roles.User)
                .Select(x => x.Id)
                .First();

            var userRole = new UserRole()
            {
                UserId = user.Id,
                RoleId = roleId
            };

            context.UserRoles.Add(userRole);
            context.SaveChanges();

            return user;
        }

        public User Login(UserLoginDto model)
        {
            throw new NotImplementedException();
        }
    }
}
