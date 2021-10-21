using System.Threading.Tasks;
using DotnetCoreSmtp.DataModel.DataModel;
using DotnetCoreSmtp.DataModel.DataModel.Concrete;
using DotnetCoreSmtp.DataModel.ResultModel.Concrete;

namespace DotnetCoreSmtp.BLL.EmailSender.Abstract
{
    public interface IEmailSender
    {
        Task<ResultModel> SendEmailAsync(EmailContentDTO emailContentDTO);
    }
}