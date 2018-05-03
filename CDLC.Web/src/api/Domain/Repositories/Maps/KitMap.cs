using CDLC.Domain.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDLC.Domain.Repositories.Maps
{
  public class KitMap : BaseMap<Kit>
  {
    public override void Map(EntityTypeBuilder<Kit> builder)
    {
      base.Map(builder);

      builder.ToTable("kit");

      builder.Property(p => p.Description).HasColumnName("description");
      builder.Property(p => p.Title).HasColumnName("title");
      builder.Property(p => p.PathIcon).HasColumnName("icon_path");
      builder.Property(p => p.Color).HasColumnName("color");

      builder.HasMany(p => p.ProductKits).WithOne(p => p.Kit);
    }
  }
}
