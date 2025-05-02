using projet_fin_etude.Models;

namespace projet_fin_etude.Data.Repository
{
    public class JobApplicantRepository : CommonRepository<JobApplicant>
    {
        private readonly MyAppDbContext _context;

        public JobApplicantRepository(MyAppDbContext context) : base(context)
        {
            _context = context;
        }
        
    }
}
