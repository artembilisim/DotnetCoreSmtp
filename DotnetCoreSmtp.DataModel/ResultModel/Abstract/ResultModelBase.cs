namespace DotnetCoreSmtp.DataModel.ResultModel.Abstract
{
    public abstract class ResultModelBase
    {
        public bool Succeed { get; set; }
        public string ExceptionMessage { get; set; }
    }
}