using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CDLC.Domain.Repositories;

namespace CDLC.Web.Controllers
{
  [Route("api/assets/{category}/{type}")]
  public sealed class AssetsController : BaseController
  {
    public AssetsController(IHostingEnvironment appEnvironment, CdlcDbContext context)
      : base(appEnvironment, context) { }

    [HttpGet]
    public IEnumerable<string> Get(string category, string type)
    {
      var path = $"{AssetsPath}\\{type}\\{category}";
      var files = Directory.GetFiles(path);
      return files.Select(f => f.Substring(f.LastIndexOf('\\') + 1));
    }
  }
}
