using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using DotnetCoreSmtp.BLL.EmailSender.Abstract;
using DotnetCoreSmtp.DataModel.DataModel.Concrete;
using DotnetCoreSmtp.DataModel.EmailSettings.Concrete;
using DotnetCoreSmtp.DataModel.ResultModel.Concrete;
using Microsoft.Extensions.Options;

namespace DotnetCoreSmtp.BLL.EmailSender.Concrete
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;
        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task<ResultModel> SendEmailAsync(EmailContentDTO emailContentDTO)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Credentials = new NetworkCredential(_emailSettings.SenderEmailAddress, _emailSettings.SenderEmailAddressPassword);
                smtpClient.Port = _emailSettings.Port;
                smtpClient.Host = _emailSettings.Host;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(_emailSettings.SenderEmailAddress, _emailSettings.SenderName);
                    mailMessage.To.Add(new MailAddress(emailContentDTO.RecipientEmailAddress));
                    mailMessage.Subject = emailContentDTO.EmailSubject;
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = emailContentDTO.EmailContent;
                    mailMessage.Priority = MailPriority.Normal;

                    await smtpClient.SendMailAsync(mailMessage);
                }

                return new ResultModel() { Succeed = true, ExceptionMessage = "", ResultObject = new List<object> { emailContentDTO } };
            }
            catch (Exception ex)
            {
                return new ResultModel() { Succeed = false, ExceptionMessage = ex.ToString(), ResultObject = new List<object> { emailContentDTO } };
            }
        }
    }
}