using System.ComponentModel.DataAnnotations;

namespace DotnetCoreSmtp.DataModel.DataModel.Concrete
{
    public class EmailContentDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string RecipientEmailAddress { get; set; }
        [Required]
        public string EmailSubject { get; set; }

        [Required]
        public string EmailContent { get; set; }
    }
}