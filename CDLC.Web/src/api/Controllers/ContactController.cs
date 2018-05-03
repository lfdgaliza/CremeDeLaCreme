using CDLC.Domain.Repositories;
using CDLC.Domain.Services;
using CDLC.Web.Shared.Dtos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace CDLC.Web.Controllers
{
   [Route("api/contact")]
   public sealed class ContactController : BaseController
   {
      private readonly IMailService _mailService;
      public ContactController(
        IHostingEnvironment appEnvironment,
        CdlcDbContext context,
        IMailService mailService)
        : base(appEnvironment, context)
      {
         _mailService = mailService;
      }

      [HttpPost]
      public void Post([FromBody]ContactDto contact)
      {
          _mailService.SendMail(contact);
      }
   }
}
