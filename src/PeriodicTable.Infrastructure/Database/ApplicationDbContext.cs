using Microsoft.EntityFrameworkCore;
using PeriodicTable.Domain.Entities;

namespace PeriodicTable.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ChemicalElement> ChemicalElements { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChemicalElement>().HasData(
                 new ChemicalElement
                 {
                     Id = Guid.NewGuid(),
                     Symbol = "H",
                     Name = "Hydrogen",
                     Group = "Nonmetal",
                     StandartState = "Gas",
                     AtomicNumber = 1,
                     Electronegativity = 2.20f,
                     MeltingPointInK = 13.81f,
                     BoilingPointInK = 20.28f,
                     YearDiscovered = 1766
                 },
                 new ChemicalElement
                 {
                     Id = Guid.NewGuid(),
                     Symbol = "He",
                     Name = "Helium",
                     Group = "Noble gas",
                     StandartState = "Gas",
                     AtomicNumber = 2,
                     Electronegativity = 2.4f,
                     MeltingPointInK = 0.95f,
                     BoilingPointInK = 4.22f,
                     YearDiscovered = 1868
                 }
             );

            base.OnModelCreating(modelBuilder);
        }
    }
}
