using System.Threading.Tasks;
using DotnetCoreSmtp.BLL.EmailSender.Abstract;
using DotnetCoreSmtp.DataModel.DataModel.Concrete;
using DotnetCoreSmtp.DataModel.ResultModel.Concrete;
using DotnetCoreSmtp.Service.Manager.Abstract;

namespace DotnetCoreSmtp.Service.Manager.Concrete
{
    public class SmtpManager : ISmtpManager
    {
        private readonly IEmailSender _emailSender;

        public SmtpManager(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task<ResultModel> SendEmailAsync(EmailContentDTO emailContentDTO)
        {
            emailContentDTO.EmailContent = emailContentDTO.EmailContent.Trim();
            emailContentDTO.EmailSubject = emailContentDTO.EmailSubject.Trim();
            emailContentDTO.RecipientEmailAddress = emailContentDTO.RecipientEmailAddress.Trim();
            return await _emailSender.SendEmailAsync(emailContentDTO);
        }
    }
}