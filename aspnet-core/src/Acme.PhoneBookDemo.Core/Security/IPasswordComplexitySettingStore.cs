using System.Threading.Tasks;

namespace Acme.PhoneBookDemo.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
