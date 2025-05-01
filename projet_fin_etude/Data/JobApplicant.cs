namespace projet_fin_etude.Data
{
    public class JobApplicant :User
    {
        public string ? FirstName { get; set; }
        public string ? LastName { get; set; }
        public string ?ProfessionalTitle { get; set; }
        public string ?EducationLevel { get; set; }
        public int ? YearsOfExperience { get; set; }     
        public string ?JobSearchType { get; set; }
        public bool ? IsMobile { get; set; }             
        public string ?CV { get; set; }
        public string? PortfolioLink { get; set; }
    }
}
