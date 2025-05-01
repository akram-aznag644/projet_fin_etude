using System.ComponentModel.DataAnnotations;

namespace projet_fin_etude.Data
{
  
        public class LoginDTO
        {
            [Required]
            
            public string Login { get; set; }

            [Required]
            public string Password { get; set; }
        }

    
}
