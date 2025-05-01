using System.ComponentModel.DataAnnotations;
using projet_fin_etude.Validation;

namespace projet_fin_etude.Models
{
    public class RegisterDTO
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]

        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;

        [RoleValidation]
        public string Role { get; set; } = string.Empty;
       
    }
}
