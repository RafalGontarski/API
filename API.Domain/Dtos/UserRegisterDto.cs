using System.ComponentModel.DataAnnotations;

namespace API.Domain.Dtos
{
    public class UserRegisterDto
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W)[A-Za-z\d\W]{8,}$",
        ErrorMessage = "The password must be at least 8 characters long, one lowercase letter, one uppercase letter, one number and one special character.")]
        public string? Password { get; set; }
    }
}
