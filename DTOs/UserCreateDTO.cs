using System.ComponentModel.DataAnnotations;

namespace UserApi.DTOs
{
    public class UserCreateDTO
    {
        [Required, MaxLength(255)]
        public required string Name { get; set; }

        [Required, EmailAddress, MaxLength(255)]
        public required string Email { get; set; }

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [Required, MinLength(6)]
        public required string Password { get; set; }
    }
}
