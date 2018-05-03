using CDLC.Web.Shared.Dtos;

namespace CDLC.Domain.Services
{
   public interface IMailService
   {
      void SendMail(ContactDto contact);
   }
}