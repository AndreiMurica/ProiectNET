using System.ComponentModel.DataAnnotations;

namespace Proiect.Models.DTOs.UserDto
{
    public class UserRequestLoginDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
