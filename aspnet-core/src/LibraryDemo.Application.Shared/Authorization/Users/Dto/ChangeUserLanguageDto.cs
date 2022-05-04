using System.ComponentModel.DataAnnotations;

namespace LibraryDemo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
