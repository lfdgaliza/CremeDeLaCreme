using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CDLC.Domain.Repositories;

namespace CDLC.Web.Controllers
{  
  public class ProductsController : BaseController
  {
    public ProductsController(IHostingEnvironment appEnvironment, CdlcDbContext context)
      : base(appEnvironment, context) { }

    [Route("api/products/featured")]
    public IEnumerable<object> Featured()
    {
      return Context.Products
        .Where(p => p.Featured)
        .Select(p => new
        {
          Id = p.Id,
          Name = p.Name,
          FileThumbName = $"{p.FileName}.png"
        });
    }

    [Route("api/products/all")]
    public IEnumerable<object> All()
    {
      return Context.Products
        .Where(p => p.Parent == null)
        .Select(p => new
        {
          Name = p.Name,
          Childreen = p.Childreen.Select(c => c.Name)
        });
    }
  }
}
