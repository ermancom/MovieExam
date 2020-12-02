using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
using Movie.Database;

namespace MovieApi
{
    public static class MigrationHostHelper
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using( var movieDbContext = scope.ServiceProvider.GetRequiredService<MovieDbContext>())
                {
                    try
                    {
                        movieDbContext.Database.Migrate();
                        movieDbContext.Database.EnsureCreated();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return host;

        }
    }
}
