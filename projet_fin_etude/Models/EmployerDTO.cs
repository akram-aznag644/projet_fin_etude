namespace projet_fin_etude.Models
{
    public class EmployerDTO:UserDTO
    {
        public string ? CompanyName { get; set; } = string.Empty;

        public string ?Description { get; set; } = string.Empty;

        public string ?Website { get; set; } = string.Empty;
        public string? SIRETNumber { get; set; }   = string.Empty;
        public string? CompanySize { get; set; } = string.Empty;
        public string? Logo { get; set; } = string.Empty;
        public DateTime? CreationDate { get; set; }
    }
}
