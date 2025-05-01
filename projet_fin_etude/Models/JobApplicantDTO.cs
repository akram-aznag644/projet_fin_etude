using System.ComponentModel.DataAnnotations;

namespace projet_fin_etude.Models
{
    public class JobApplicantDTO : UserDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; } 
        [Required]

        public string ProfessionalTitle { get; set; } 
        [Required]
        public string EducationLevel { get; set; } 
        [Required]

        public int  YearsOfExperience { get; set; } 
        [Required]

        public string JobSearchType { get; set; } 
        public bool ? IsMobile { get; set; }
        [Required]

        public string CV { get; set; }
        public string PortfolioLink { get; set; }

    }
}
