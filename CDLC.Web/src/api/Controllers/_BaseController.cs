using CDLC.Domain.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace CDLC.Web.Controllers
{
   public abstract class BaseController : Controller
   {
      protected readonly IHostingEnvironment AppEnvironment;
      protected readonly CdlcDbContext Context;
      private string _rootPath
      {
         get
         {
            return AppEnvironment.IsDevelopment()
            ? "src"
            : "wwwroot";
         }
      }
      protected string AssetsPath => $"{AppEnvironment.ContentRootPath}\\{_rootPath}\\assets";

      public BaseController(IHostingEnvironment appEnvironment, CdlcDbContext context)
      {
         AppEnvironment = appEnvironment;
         Context = context;
      }
   }
}
