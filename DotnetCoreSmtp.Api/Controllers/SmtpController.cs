using System.Threading.Tasks;
using DotnetCoreSmtp.DataModel.DataModel.Concrete;
using DotnetCoreSmtp.Service.Manager.Abstract;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreSmtp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
    public class SmtpController : ControllerBase
    {
        private readonly ISmtpManager _smtpManager;

        public SmtpController(ISmtpManager smtpManager)
        {
            _smtpManager = smtpManager;
        }

        [HttpPost, Route("send/email")]
        public async Task<IActionResult> SenEmailAsync([FromBody] EmailContentDTO emailContentDTO)
        {
            var sendEmailResult = await _smtpManager.SendEmailAsync(emailContentDTO);
            return sendEmailResult.Succeed ? Ok() : BadRequest();
        }
    }
}