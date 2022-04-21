using System.ComponentModel.DataAnnotations;

namespace Acme.PhoneBookDemo.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}