using CDLC.Domain.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDLC.Domain.Repositories.Maps
{
    public class ProductKitMap : BaseMap<ProductKit>
    {
    public override void Map(EntityTypeBuilder<ProductKit> builder)
    {
      base.Map(builder);

      builder.ToTable("productkit");

      builder.Property(p => p.Kit_Id).HasColumnName("id_kit");
      builder.Property(p => p.Product_Id).HasColumnName("id_product");
      builder.Property(p => p.ProductQtt).HasColumnName("qtt_product");

      builder.HasOne(p => p.Product).WithMany(p => p.ProductKits);
      builder.HasOne(p => p.Kit).WithMany(p => p.ProductKits);
    }
  }
}
