
namespace API.Domain.Enums
{
    public static class Roles
    {
        public const string User = "USER";
        public const string Admin = "ADMIN";
        public const string Owner = "OWNER";
        public const string Director = "DIRECTOR";
        public const string Manager = "MANAGER";
        public const string Employee = "EMPLOYEE";

        public static IEnumerable<string> GetRoles() => [ User, Admin, Owner, Director, Manager, Employee ];
    }
}
