using CDLC.Domain.Repositories.Entities;
using CDLC.Domain.Repositories.Maps;
using Microsoft.EntityFrameworkCore;

namespace CDLC.Domain.Repositories
{
  public class CdlcDbContext : DbContext
  {
    public CdlcDbContext(DbContextOptions<CdlcDbContext> options)
      : base(options)
    { }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.AddConfiguration(new ProductMap());
    }
  }
}
