using System.ComponentModel.DataAnnotations;

namespace Acme.PhoneBookDemo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
