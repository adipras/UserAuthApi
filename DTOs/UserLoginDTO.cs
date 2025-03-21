using System.ComponentModel.DataAnnotations;

namespace UserApi.DTOs
{
    public class UserLoginDTO
    {
        [Required, EmailAddress, MaxLength(255)]
        public required string Email { get; set; }

        [Required, MinLength(6)]
        public required string Password { get; set; }
    }
}
