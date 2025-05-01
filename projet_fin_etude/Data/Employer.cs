using System.ComponentModel.DataAnnotations;

namespace projet_fin_etude.Data
{
    public class Employer : User
    {
        public string? CompanyName { get; set; }

        public string ? Description { get; set; }


        public string ? Website { get; set; }
        public string ? SIRETNumber { get; set; }
        public string  ? CompanySize { get; set; }
        public string  ? Logo { get; set; }
        public DateTime CreationDate { get; set; }
       
    }
}
