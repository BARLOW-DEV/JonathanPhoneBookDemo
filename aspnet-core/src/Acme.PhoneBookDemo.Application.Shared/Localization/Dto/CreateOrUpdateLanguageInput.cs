using System.ComponentModel.DataAnnotations;

namespace Acme.PhoneBookDemo.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}