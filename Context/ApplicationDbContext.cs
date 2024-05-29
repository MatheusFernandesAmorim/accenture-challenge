using AccentureChallenge.UI.CQRS.Models;
using Microsoft.EntityFrameworkCore;

namespace AccentureChallenge.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) : base(contextOptions)
        {
                
        }

        public DbSet<Sales> Sales { get; set; }
    }
}
