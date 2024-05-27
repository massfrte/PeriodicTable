using Microsoft.EntityFrameworkCore;
using PeriodicTable.Domain.Entities;

namespace PeriodicTable.Infrastructure.Database
{
	public class ApplicationDbContext : DbContext
	{
        public DbSet<ChemicalElement> ChemicalElements { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
	}
}
