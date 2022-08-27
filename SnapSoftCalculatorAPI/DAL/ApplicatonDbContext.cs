using Microsoft.EntityFrameworkCore;

namespace SnapSoftCalculatorAPI.DAL
{
  public class ApplicatonDbContext : DbContext
  {
    public ApplicatonDbContext(DbContextOptions<ApplicatonDbContext> options) : 
      base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.UseSerialColumns();
    }

    public DbSet<StoredCalculation> StoredCalculations { get; set; }

    public DbSet<StoredNumber> StoredNumbers { get; set; }
  }
}
