using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace projet_fin_etude.Data.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(u => u.Username)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.HasIndex(u => u.Username).IsUnique();

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(u => u.Email)
                   .IsUnique();

            builder.Property(u => u.Password)
                   .IsRequired();

            builder.Property(u => u.Role)
                   .IsRequired()
                   .HasMaxLength(20);

            // TPH inheritance mapping
            builder.HasDiscriminator<string>("UserType")
                   .HasValue<Admin>("Admin")
                   .HasValue<Employer>("Employer")
                   .HasValue<JobApplicant>("JobApplicant")

                   ;

          
        }

        // hashing password


    }
}
