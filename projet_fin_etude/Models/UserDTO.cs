using System.ComponentModel.DataAnnotations;
using projet_fin_etude.Validation;

namespace projet_fin_etude.Models
{
    public abstract class UserDTO
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        public string HashedPassword { get; set; } = string.Empty;
        [Required]
        [Phone]
        public string Phone { get; set; } = string.Empty;

        public string Profile { get; set; } = string.Empty;
        [Required]
        [RoleValidation]
        public string Role { get; set; } = string.Empty;
      
    }
}
