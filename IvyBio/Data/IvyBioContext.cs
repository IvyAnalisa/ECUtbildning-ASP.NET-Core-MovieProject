using IvyBio.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IvyBio.Data
{
    public class IvyBioContext : IdentityDbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }

        public IvyBioContext(DbContextOptions<IvyBioContext> options)

            : base(options) { }
    }
}
