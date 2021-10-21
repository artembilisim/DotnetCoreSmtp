using System.Threading.Tasks;
using DotnetCoreSmtp.DataModel.DataModel.Concrete;
using DotnetCoreSmtp.DataModel.ResultModel.Concrete;

namespace DotnetCoreSmtp.Service.Manager.Abstract
{
    public interface ISmtpManager
    {
        Task<ResultModel> SendEmailAsync(EmailContentDTO emailContentDTO);
    }
}