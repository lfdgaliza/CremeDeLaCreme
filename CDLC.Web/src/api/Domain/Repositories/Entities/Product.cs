using System.Collections.Generic;

namespace CDLC.Domain.Repositories.Entities
{
   public class Product : BaseEntity
   {
      public string Name { get; set; }
      public string FileName { get; set; }
      public bool Featured { get; set; }
      public int? ParentId { get; set; }
      public Product Parent { get; set; }

      public IEnumerable<Product> Childreen { get; set; }
      public IEnumerable<ProductKit> ProductKits { get; set; }
   }
}
