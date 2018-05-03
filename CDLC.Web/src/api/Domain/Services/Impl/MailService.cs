using System;
using System.Net;
using System.Text;
using CDLC.Shared.Constants;
using CDLC.Web.Shared.Dtos;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Hosting;
using MimeKit;
using MimeKit.Text;

namespace CDLC.Domain.Services.Impl
{
   public class MailService : IMailService
   {
      private readonly IHostingEnvironment _appEnvironment;
      public MailService(IHostingEnvironment appEnvironment)
      {
         _appEnvironment = appEnvironment;
      }
      // todo: enviar configurações para o webconfig
      public void SendMail(ContactDto contact)
      {
         var message = new MimeMessage();
         message.From.Add(new MailboxAddress("Form Contato", "contato@cremedelacremepe.com"));
         message.To.Add(new MailboxAddress("Contato", "contato@cremedelacremepe.com"));
         message.Subject = contact.Subject;

         message.Body = new TextPart("html")
         {

            Text = WebUtility
            .HtmlEncode($"{contact.Message}\n\nEndereço de e-mail do remetente:{contact.Email}")
            .Replace("\n", "<br />")
         };

         using (var client = new SmtpClient())
         {
            // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
            client.ServerCertificateValidationCallback = (s, c, h, e) => true;

            client.Connect(_appEnvironment.IsDevelopment()
            ? MailConstants.SmtpAddressDevelopment
            : MailConstants.SmtpAddressProduction, 587, false);

            // Note: since we don't have an OAuth2 token, disable
            // the XOAUTH2 authentication mechanism.
            client.AuthenticationMechanisms.Remove("XOAUTH2");

            // Note: only needed if the SMTP server requires authentication
            //client.Authenticate ("joey", "password");

            client.Send(message);
            client.Disconnect(true);
         }
      }
   }
}