using System.ComponentModel.DataAnnotations;

namespace Datingapp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(256, MinimumLength=8, ErrorMessage="Password must be at least 8 characters.")]
        public string Password { get; set; }
    }
}