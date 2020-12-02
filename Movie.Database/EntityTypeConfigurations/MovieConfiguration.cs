using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace Movie.Database.EntityTypeConfigurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie.Entities.Movie>
    {
        public void Configure(EntityTypeBuilder<Entities.Movie> builder)
        {
            builder.Property(p => p.ID)
                   .ValueGeneratedOnAdd();
            builder.HasKey(key => key.ID);
            
            builder.Property(p => p.Title);

            builder.Property(p => p.YearOfRelease);

            builder.Property(p => p.RunningTime);

            builder.Property(p => p.Title).HasMaxLength(100);
        }
    }
}
