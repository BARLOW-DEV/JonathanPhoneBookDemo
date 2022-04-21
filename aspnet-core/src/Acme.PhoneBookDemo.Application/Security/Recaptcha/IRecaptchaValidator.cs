using System.Threading.Tasks;

namespace Acme.PhoneBookDemo.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}