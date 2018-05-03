using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CDLC.Domain.Repositories;

namespace CDLC.Web.Controllers
{
   [Route("api/[controller]")]
   public class KitController : BaseController
   {

      public KitController(IHostingEnvironment appEnvironment, CdlcDbContext context)
      : base(appEnvironment, context)
      { }

      [HttpGet]
      public IEnumerable<string> Get()
      {
         var result = Context.Products.Select(p => p.Name).ToList();
         return result;
      }
   }
}
