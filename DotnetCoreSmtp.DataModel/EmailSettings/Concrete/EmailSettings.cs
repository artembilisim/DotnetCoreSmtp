namespace DotnetCoreSmtp.DataModel.EmailSettings.Concrete
{
    public class EmailSettings
    {
        public string SenderEmailAddress { get; set; }
        public string SenderEmailAddressPassword { get; set; }
        public string SenderName { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
    }
}