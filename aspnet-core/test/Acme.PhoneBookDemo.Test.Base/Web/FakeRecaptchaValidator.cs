using System.Threading.Tasks;
using Acme.PhoneBookDemo.Security.Recaptcha;

namespace Acme.PhoneBookDemo.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
