using System.Collections.Generic;

namespace CDLC.Domain.Repositories.Entities
{
  public class Kit : BaseEntity
  {
    public string PathIcon { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Color { get; set; }

    public IEnumerable<ProductKit> ProductKits { get; set; }
  }
}
