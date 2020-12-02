using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Entities;


namespace Movie.Database.EntityTypeConfigurations
{
    public class MovieRateConfiguration : IEntityTypeConfiguration<MovieRate>
    {
        public void Configure(EntityTypeBuilder<MovieRate> builder)
        {
            builder.Property(p => p.ID)
                  .ValueGeneratedOnAdd();
            builder.HasKey(key => key.ID);

            builder.Property(p => p.MovieID);

            builder.Property(p => p.UserID);

            builder.Property(p => p.UserRate);

            builder.HasOne(mr => mr.Movie)
                   .WithMany(m => m.MovieRates)
                   .HasForeignKey(b => b.MovieID);

            builder.HasOne(mr => mr.MovieUser)
                   .WithMany(m => m.MovieRates)
                   .HasForeignKey(b => b.UserID);
        }
    }
}
