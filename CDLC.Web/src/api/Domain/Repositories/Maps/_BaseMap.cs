using CDLC.Domain.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDLC.Domain.Repositories.Maps
{
  public abstract class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
  {
    public override void Map(EntityTypeBuilder<T> builder)
    {
      builder.HasKey(k => k.Id);

      builder
        .Property(p => p.Id)
        .HasColumnName("id");
    }
  }
}
