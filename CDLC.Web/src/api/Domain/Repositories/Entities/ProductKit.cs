namespace CDLC.Domain.Repositories.Entities
{
  public class ProductKit : BaseEntity
  {
    public virtual Product Product { get; set; }
    public int Product_Id { get; set; }

    public virtual Kit Kit { get; set; }
    public int Kit_Id { get; set; }

    public int ProductQtt { get; set; }
  }
}
