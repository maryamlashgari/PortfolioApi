using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class PortfolioDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {

        }
    }
}