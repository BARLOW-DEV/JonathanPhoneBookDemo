using System.Globalization;

namespace Acme.PhoneBookDemo.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}