using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace projet_fin_etude.Data.Config
{
    public class JobApplicantConfig : IEntityTypeConfiguration<JobApplicant>
    {
        public void Configure(EntityTypeBuilder<JobApplicant> builder)
        {
            builder.HasBaseType<User>();
           
        }
    }
}
