
using CDLC.Domain.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDLC.Domain.Repositories.Maps
{
   public class ProductMap : BaseMap<Product>
   {
      public override void Map(EntityTypeBuilder<Product> builder)
      {
         base.Map(builder);

         builder.ToTable("product");

         builder.Property(p => p.Name).HasColumnName("name");
         builder.Property(p => p.FileName).HasColumnName("file_name");
         builder.Property(p => p.Featured).HasColumnName("featured");
         builder.Property(p => p.ParentId).HasColumnName("id_parent");

         builder.HasMany(p => p.Childreen).WithOne(p => p.Parent);
         
         builder.HasMany(p => p.ProductKits).WithOne(p => p.Product);
      }
   }
}
