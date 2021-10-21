using System.Collections.Generic;
using DotnetCoreSmtp.DataModel.ResultModel.Abstract;

namespace DotnetCoreSmtp.DataModel.ResultModel.Concrete
{
    public class ResultModel : ResultModelBase
    {
        public ICollection<object> ResultObject { get; set; }
    }
}