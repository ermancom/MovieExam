
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Entities;

namespace Movie.Database.EntityTypeConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.ID)
                   .ValueGeneratedOnAdd();
            builder.HasKey(key => key.ID);

            
            builder.Property(p => p.Password)
                   .HasMaxLength(100);

            builder.Property(p => p.Username)
                   .HasMaxLength(50);
        }
    }
}
